using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Spoor
    {
        private int Spoornummer { get; set; }
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
