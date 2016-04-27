using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Sector
    {
        
        public int SectorNumber { get; set; }
        public int RailID { get; set; }
        
        
        public Sector(int sectorNumber, int RailID)
        {
            this.SectorNumber = sectorNumber;
            this.RailID = RailID;
        }
    }
}
