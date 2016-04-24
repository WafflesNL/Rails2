using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    class techniekPlanning
    {
        private DateTime Date;
        private int TramNr;
        private int Technician;
        private string Type;
        private int Duration;

        public techniekPlanning(DateTime Date, int TramNr, int Technician, string Type, int Duration)
        {
            this.Date = Date;
            this.TramNr = TramNr;
            this.Technician = Technician;
            this.Type = Type;
            this.Duration = Duration;
            
        }

        public void AddReparation()
        {
            string a = Convert.ToString(this.Date);
            string dates = a.Substring(' ');
            string newReparation = "INSERT INTO MECHANIC_SCHEDULE (TRAM_ID, USER_ID, DATE, Duration) VALUES (" + this.TramNr + "," + this.Technician + "," + dates[0] + "," + dates[1] + "," + this.Duration + ")";
            DataCom.nonQuery(newReparation);
        }

        public void RemoveReparatie()
        {
            string deleteReparation = "DELETE FROM MECHANIC_SCHEDULE (TRAM_ID)";
            DataCom.nonQuery(deleteReparation);
        }

        public void CheckReparatie()
        {

        }
    }
}
