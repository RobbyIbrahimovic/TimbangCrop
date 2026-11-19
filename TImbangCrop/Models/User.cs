using System;
using System.Collections.Generic;
using System.Text;

namespace TimbangCrop.Models
{
    public abstract class User
    {
        public string IdUser { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        protected User(string idUser, string nama, string username, string passwordHash)
        {
            IdUser = idUser;
            Nama = nama;
            Username = username;
            PasswordHash = passwordHash;
        }

        public abstract bool CanAccessModule(string moduleName);
    }

    public class Pekerja : User
    {
        public Pekerja(string idUser, string nama, string username, string passwordHash)
            : base(idUser, nama, username, passwordHash)
        {
        }

        public override bool CanAccessModule(string moduleName)
        {
            return moduleName == "Penerimaan" || moduleName == "Penimbangan" || moduleName == "Riwayat";
        }
    }

    public class Mandor : User
    {
        public Mandor(string idUser, string nama, string username, string passwordHash)
            : base(idUser, nama, username, passwordHash)
        {
        }

        public override bool CanAccessModule(string moduleName)
        {
            return true;
        }
    }
}