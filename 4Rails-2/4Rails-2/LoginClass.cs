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
            string[] columns = new string[2] { "password", "function_id" };
            List<string[]> temp = DataCom.ReadAll("password, function_id", "user_", "username = " + "'" + Username + "'", columns);

            foreach(string[] t in temp)
            {
                if (t[0] == Password)
                    return t[1];
            }
            return null;
        }
    }
}
