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
        
        private bool Blocked { get; set; }

        public Spoor(int spoornummer, bool blocked)
        {
            this.Spoornummer = spoornummer;
            this.Blocked = blocked; 
        }
    }
}
