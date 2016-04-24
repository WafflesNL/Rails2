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

            returnvalue = DataCom.ReadAll("Tram_ID, Rail_ID", "Regulation");

            return returnvalue;
        }
    }
}
