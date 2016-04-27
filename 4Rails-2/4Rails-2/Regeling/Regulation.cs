using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Regulation
    {
        public int tramNr { get; set; }
        public int spoorNr { get; set; }
        public string User { get; set; }
        public string tramstatus { get; set; }

        public Regulation(int tramNr, int spoorNr, string User, string tramstatus)
        {
            this.tramNr = tramNr;
            this.spoorNr = spoorNr;
            this.User = User;
            this.tramstatus = tramstatus;
        }

        
    }
}
