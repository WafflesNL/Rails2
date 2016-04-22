using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    class techniekPlanning
    {
        //Fields
        private DateTime Date;
        private int tramNR;
        private int technician;
        private String type;
        private int duration;

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
        public void AddCleaning()
        {
            //Insert a row to table
            string newCleaning = "INSERT INTO MECHANIC_SCHEDULE(tram_id, user_id, time, duration) VALUES (" + this.tramNR + ", " + this.technician + ", " + this.Date + ", " + this.duration + ");";
            DataCom.nonQuery(newCleaning);
        }

        public void RemoveCleaning()
        {
            //Delete a row from table
            string removeCleaning = "DELETE FROM MECHANIC_SCHEDULE WHERE tram_id =" + this.tramNR + ";";
            DataCom.nonQuery(removeCleaning);
        }

        public void CheckSchoonmaak()
        {
            //Search for all the trams that need to be cleaned
            List<string[]> data = DataCom.ReadAll("Tram_id,User_ID,Date_,Time,Duration", "Mechaninic_Schedule", null);
        }
    }
}
