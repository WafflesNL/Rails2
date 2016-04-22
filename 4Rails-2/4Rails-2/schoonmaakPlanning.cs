using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class CleaningPlanning
    {
        //Fields
        private DateTime Date;
        private int tramNR;
        private int cleaner;
        private String type;
        private int duration;
        public List<string[]> data = new List<string[]>();

        //Constructor
        public CleaningPlanning(DateTime time, int tramNR, int cleaner, string type, int duration)
        {
            this.Date = time;
            this.tramNR = tramNR;
            this.cleaner = cleaner;
            this.type = type;
            this.duration = duration;
        }

        public CleaningPlanning() { }

        //Methods
        public void AddCleaning()
        {
            //Insert a row to table
            string a = Convert.ToString(this.Date);
            string dates = a.Substring(' ');
            string newCleaning = "INSERT INTO CLEANING_SCHEDULE(tram_id, user_id, date_, time, duration) VALUES (" + this.tramNR + ", " + this.cleaner + ", " + dates[0] + ", " + dates[1] + ", " + this.duration + ");";
            DataCom.nonQuery(newCleaning);
        }

        public void RemoveCleaning()
        {
            //Delete a row from table
            string removeCleaning = "DELETE FROM CLEANING_SCHEDULE WHERE tram_id =" + this.tramNR + ";";
            DataCom.nonQuery(removeCleaning);
        }

        public List<string[]> CheckSchoonmaak()
        {
            //Search for all the trams that need to be cleaned
            return data = DataCom.ReadAll("Tram_id,User_ID,Date_,Time,Duration", "Cleaning_Schedule", null); 
        }
    }
}
