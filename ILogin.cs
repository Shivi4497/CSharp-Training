using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assessment
{
   interface ILogin
    {
        bool IsValidUser(string username, string password);
    }
}
