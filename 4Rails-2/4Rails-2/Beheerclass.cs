using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Beheerclass
    {
        public List<string[]> tramnrlist = DataCom.ReadAll("Tram_ID, Tramstatus", "Tram");
    }
}
