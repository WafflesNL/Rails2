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

        public bool Check(string Username, string Password)
        {
            string temp = DataCom.Read("wachtwoord", "gebruiker", "naam = " + Username, "wachtwoord");
            if (temp == Password)
                return true;
            return false;
        }
    }
}
