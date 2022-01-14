using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_In_1_Planning.Models;
using Microsoft.EntityFrameworkCore;

namespace All_In_1_Planning.Data
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL(
                    @"Server=localhost;Database=All-In-1Planning;Username=root;SslMode=none;");
        }
    }
}