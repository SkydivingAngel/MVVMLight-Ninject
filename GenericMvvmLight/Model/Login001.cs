using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GenericMvvmLight.Model
{
    public class Login001 : ILogin
    {
        public bool TryLogin(string username, string password)
        {
            bool isLogged = true;
            if (username != File.ReadAllText("Login001.txt").Split(new string[] { ";"}, StringSplitOptions.RemoveEmptyEntries)[0] || password != File.ReadAllText("Login001.txt").Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)[1])
                return false;
            return isLogged;
        }

        public string GetLastLogin()
        {
            return File.ReadAllText("LoginLast.txt").Trim();
        }

        public void SetLastLogin(string username)
        {
            MessageBox.Show("Login001");
            File.WriteAllText("LoginLast.txt", username);
        }
    }
}
