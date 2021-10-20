﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_In_1_Planning.Models;
using Microsoft.EntityFrameworkCore;

namespace All_In_1_Planning.Data
{
    public class Context : DbContext
    {
        private DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL(
                    @"Server=localhost;Database=All-In-1Planning;Uid=root;Pwd=;SslMode=None");
        }
    }
}