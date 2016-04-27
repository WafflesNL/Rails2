using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Spoor
    {
        public int Spoornummer { get; private set; }
        private int SectorNummer { get; set; }
        private bool Blocked { get; set; }

        public Spoor(int spoornummer, int sectorNummer)
        {
            this.Spoornummer = spoornummer;
            this.SectorNummer = sectorNummer;
            Blocked = false;
        }
    }
}
