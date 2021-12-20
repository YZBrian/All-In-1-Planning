using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_In_1_Planning.Data;
using All_In_1_Planning.Logic;
using All_In_1_Planning.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace All_In_1_Planning.Logic
{
    public class EventLogic
    {
        MySqlDataReader reader;
        readonly MySqlConnection dataBaseConnection = DbConn.Connection();

        public bool CreateEvent(DateTime dateTime, string description)
        {
            string query = "INSERT INTO events (dateTime, description) VALUES (@dateTime, @description);";
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            dataBaseConnection.Open();
            command.Parameters.AddWithValue("@dateTime", dateTime);
            command.Parameters.AddWithValue("@Description", description);

            command.ExecuteNonQuery();
            return true;
        }

        public async Task<EventListModel> GetAllEvents()
        {
            EventListModel eventList = new EventListModel(new List<EventModel>());
            string query = "SELECT * FROM events;";
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            dataBaseConnection.Open();

            reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int eventId = reader.GetInt32("Id");
                        DateTime eventDateTime = reader.GetDateTime("DateTime");
                        string eventDescription = reader.GetString("Description");
                        EventModel eventModel = new EventModel(eventId, eventDateTime, eventDescription);

                        eventList.Events.Add(eventModel);
                    }

                    return eventList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;
        }

        public bool DeleteEvent(int id)
        {
            string query = "DELETE FROM events WHERE Id=@id";
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            dataBaseConnection.Open();
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            return true;
        }

    }
}
