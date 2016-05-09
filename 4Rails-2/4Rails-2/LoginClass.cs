using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class LoginClass
    {
        public LoginClass()
        {

        }

        public string Check(string Username, string Password)
        {
            List<string[]> temp = DataCom.ReadAll("Password, FunctionID", "Gebruiker", "Username = " + "'" + Username + "'");

            foreach(string[] t in temp)
            {
                if (t[0] == Password)
                    return t[1];
            }
            return null;
        }
    }
}
