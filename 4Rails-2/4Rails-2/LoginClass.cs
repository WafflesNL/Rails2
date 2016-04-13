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
            string[] temp = DataCom.Read("password, function_id", "user_", "username = " + "'" + Username + "'", columns);

            if (temp[0] == Password)
                return temp[1];
            return null;
        }
    }
}
