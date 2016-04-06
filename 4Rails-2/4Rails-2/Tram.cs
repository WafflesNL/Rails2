using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Tram
    {
        enum tramStatus
        {
            Defect,
            Schoonmaak,
            Dienst,
            Remise
        };

        /// <summary>
        /// G11 = 11G
        /// G12 = 12G
        /// </summary>
        enum tramType
        {
            Combino,
            G11,
            Dubbelkop_Combino,
            G12,
            OpleidingsTrams
        };

        private tramType TramType;
        private tramStatus TramStatus;

        private int TramNR;
        private int Bestemming;
        private int HuidigSpoorNR;

        public Tram()
        {

        }

        public void AddTram()
        {

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
