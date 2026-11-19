using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using TimbangCrop.Models;

namespace TimbangCrop.Data
{
    public class UserDAO
    {
        public static User Autentikasi(string username, string password)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string sql = "SELECT id_user, nama, username, password_hash, role FROM users WHERE username = @u AND password_hash = @p";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("u", username);
            cmd.Parameters.AddWithValue("p", password);

            using var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                string id = rd.GetString(0);
                string nama = rd.GetString(1);
                string user = rd.GetString(2);
                string pass = rd.GetString(3);
                string role = rd.GetString(4);

                if (role.Equals("Mandor", StringComparison.OrdinalIgnoreCase))
                    return new Mandor(id, nama, user, pass);
                else
                    return new Pekerja(id, nama, user, pass);
            }

            return null;
        }
    }
}