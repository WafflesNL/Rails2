using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Trams
    {
        public List<Tram> trams;

        public Trams()
        {
            trams = new List<Tram>();
        }

        public void AddTram(int tramnr)
        {
            Tram tram = new Tram(tramnr);
            trams.Add(tram);
        }

        public void RemoveTram()
        {

        }

        public void AddBestemming()
        {

        }

        public void AlterBestemming()
        {

        }
    }
}
