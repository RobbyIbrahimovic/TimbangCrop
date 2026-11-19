using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace TimbangCrop.Data
{
    public class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;Database=timbangcrop_db;Username=postgres;Password=123";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}