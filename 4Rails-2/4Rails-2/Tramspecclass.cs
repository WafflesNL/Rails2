using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    class Tramspecclass
    {
        public string tramclass;
        public void onload(string tramnr)
        {
            tramclass = DataCom.Read("Tramstatus", "Tram", "Tram_ID = " + tramnr, "Tramstatus");
        }
        public void modify(string status, string tramnr)
        {
            DataCom.nonQuery("UPDATE Tram SET Tramstatus = "+ "'" + status + "'" +" WHERE Tram_ID = "+ tramnr);
        }
    }
}
