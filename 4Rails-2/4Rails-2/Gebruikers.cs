using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Gebruikers
    {
        public int FunctieID { get; set; }
        public string Naam { get; set; }

        public Gebruikers(int functieID, string naam)
        {
            this.FunctieID = functieID;
            this.Naam = naam;
        }
    }
}
