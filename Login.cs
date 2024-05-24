using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assessment
{
   
    public class Login : ILogin
    {
        public bool IsValidUser(string _username, string _password)
        {
            if(_username == "admin" && _password == "1234")
                return true;

            else
                return false;
        }
    }
}
