using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    public class Login002 : ILogin
    {
        public bool TryLogin(string username, string password)
        {
            bool isLogged = true;
            if (username != File.ReadAllText("Login002.txt").Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries)[0] || password != File.ReadAllText("Login002.txt").Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries)[1])
                return false;
            return isLogged;
        }
    }
}
