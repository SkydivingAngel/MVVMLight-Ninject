using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMvvmLight.Model
{
    public interface ILogin
    {
        bool TryLogin(string username, string password);
        string GetLastLogin();
        void SetLastLogin(string username);
    }
}
