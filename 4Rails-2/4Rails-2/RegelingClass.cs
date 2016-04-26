using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class RegelingClass
    {
        public RegelingClass() { }

        public List<string[]> GetData()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("r.Tram_ID, Rail_ID, User_ID, TramStatus", "Regulation r, Tram t", "r.Tram_ID = t.Tram_ID");

            return returnvalue;
        }
    }
}
