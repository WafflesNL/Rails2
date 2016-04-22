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

            returnvalue = DataCom.ReadAll("r.Tram_ID, t.Rail_ID", "Regulation r,Tram t", "r.tram_id = t.tram_id");

            return returnvalue;
        }
    }
}
