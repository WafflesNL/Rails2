using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Tram
    {
        public int TramNR { get; set; } 
        private int Bestemming { get; set; }
        public int HuidigSpoorNR { get; set; }
        public int HuidigSectorNR { get; set; }
        public string tramstatus { get; set; }
        public string tramType { get; set; }
        

        public Tram(int tramnr, int huidigSpoorNR, string tramstatus, int bestemming, string tramType, int huidigSectorNR)
        {
            this.TramNR = tramnr;
            this.HuidigSpoorNR = huidigSpoorNR;
            this.tramstatus = tramstatus;
            this.Bestemming = bestemming;
            this.tramType = tramType;
            this.HuidigSectorNR = huidigSectorNR;
        }
    }
}
