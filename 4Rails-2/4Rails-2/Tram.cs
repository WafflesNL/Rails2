using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Tram
    {
        
        private tramType TramType;
        private tramStatus TramStatus;

        public int TramNR { get; private set; } 
        private int Bestemming;
        private int HuidigSpoorNR;

        public Tram(int tramnr)
        {
            this.TramNR = tramnr;
        }

    }
}
