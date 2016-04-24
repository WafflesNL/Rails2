using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class techniekPlanning
    {
        //Fields
        private DateTime Date;
        private int tramNR;
        private int technician;
        private String type;
        private int duration;
        public List<string[]> data = new List<string[]>();

        //Constructor
        public techniekPlanning(DateTime time, int tramNR, int cleaner, string type, int duration)
        {
            this.Date = time;
            this.tramNR = tramNR;
            this.technician = cleaner;
            this.type = type;
            this.duration = duration;
        }

        public techniekPlanning() { }

        //Methods
        public void AddRepair()
        {
            //Insert a row to table
            string newRepair = "INSERT INTO MECHANIC_SCHEDULE(tram_id, user_id, time, duration) VALUES (" + this.tramNR + ", " + this.technician + ", " + this.Date + ", " + this.duration + ");";
            DataCom.nonQuery(newRepair);
        }

        public void RemoveRepair()
        {
            //Delete a row from table
            string removeRepair = "DELETE FROM MECHANIC_SCHEDULE WHERE tram_id =" + this.tramNR + ";";
            DataCom.nonQuery(removeRepair);
        }

        public List<string[]> CheckTechniek()
        {
            //Search for all the trams that need to be repaired
            return data = DataCom.ReadAll("m.Tram_ID, m.User_ID, m.Time, m.Duration, t.Status", "Mechanic_Schedule m, Tram t", "t.Tram_ID = m.Tram_ID");
        }
    }
}
