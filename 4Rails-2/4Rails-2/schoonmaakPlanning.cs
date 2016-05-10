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
        public void AddCleaning(string tramNR, string personeel, string datum, string duration)
        {
            //Insert a row to table
            string newCleaning = "INSERT INTO Clean(CleanID, UserID, TramID, timeStart, timeEnd, Description) VALUES (" + tramNR + ", " + personeel + ", " + datum + ");";
            DataCom.nonQuery(newCleaning);
        }

        public void RemoveCleaning()
        {
            //Delete a row from table
            string removeCleaning = "DELETE FROM Clean WHERE TramID =" + this.tramNR + ";";
            DataCom.nonQuery(removeCleaning);
        }

        public List<string[]> CheckSchoonmaak()
        {
            //Search for all the trams that need to be cleaned
            return data = DataCom.ReadAll("c.TramID, c.UserID, c.Time, c.Duration, t.Tramstatus", "Clean c, Tram t", "c.TramID = t.TramID AND t.Tramstatus = 'Schoonmaak'");
        }
    }
}
