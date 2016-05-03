using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Overview
    {

        //Sector
        private List<string[]> sectorList;
        private List<Sector> sectors;

        //Regulations
        private List<string[]> regulationList;
        public List<Regulation> regulations;

        //Rails
        private List<string[]> railList;
        public List<Spoor> rails;

        //Trams
        private List<string[]> tramlist;
        public List<Tram> trams;

        //Schoonmaak
        public List<string[]> data1 = new List<string[]>();

        //Techniek
        public List<string[]> data2 = new List<string[]>();

        //Trampspec
        public string tramclass;

        public Overview()
        {
            trams = new List<Tram>();
            tramlist = new List<string[]>();
            rails = new List<Spoor>();
            railList = new List<string[]>();
            sectorList = new List<string[]>();
            sectors = new List<Sector>();
            regulationList = new List<string[]>();
            regulations = new List<Regulation>();
            refreshDatabase();

        }

        public void refreshDatabase()
        {
            refreshSectors();
            refreshRegulations();
            refreshTram();
            refreshRails();
        }

        //Sectors
        public void getSector()
        {
            foreach (string[] items in sectorList)
            {
                int sectorNumber = Convert.ToInt32(items[0]);
                int railID = Convert.ToInt32(items[1]);

                Sector sector = new Sector(sectorNumber, railID);
                sectors.Add(sector);
            }
        }

        public List<string[]> obtainSector()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("Sector_ID, Rail_ID", "Sector");

            return returnvalue;
        }

        public void newSector(int sectorNumber, int railID)
        {
            Sector sector = new Sector(sectorNumber, railID);
            refreshRegulations();
        }

        public void refreshSectors()
        {
            sectorList.Clear();
            sectorList = obtainSector();
            sectors.Clear();
            getSector();
        }

        //Regulations
        public void getRegulation()
        {
            foreach (string[] items in regulationList)
            {
                int tramNr = Convert.ToInt32(items[0]);
                int spoorNr = Convert.ToInt32(items[1]);
                string user = Convert.ToString(items[2]);
                string tramstatus = Convert.ToString(items[3]);
                Regulation regulation = new Regulation(tramNr, spoorNr, user, tramstatus);
                regulations.Add(regulation);
            }
        }

        public List<string[]> obtainRegulation()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("r.Tram_ID, Rail_ID, User_ID, TramStatus", "Regeling r, Tram t", "r.Tram_ID = t.Tram_ID");

            return returnvalue;
        }

        public void newRegulation(int tramNr, int spoorNr, string User, string tramStatus)
        {
            regulations.Clear();
            foreach (Tram tram in trams)
            {
                int tramID = tram.TramNR;
                string Number = DataCom.getCount();
                int count = Convert.ToInt32(Number) + 1;

                string addRegulation = "INSERT INTO Regulation(Regulation_ID, Tram_ID) VALUES ('" + count + "', '" + tramID + "')";
                DataCom.nonQuery(addRegulation);

                string update = "UPDATE Tram SET TramStatus= '" + tramStatus + "'," + "Rail_ID='" + spoorNr + "'" + " WHERE Tram_ID ='" + tramNr + "')";
                DataCom.nonQuery(update);
            }



            refreshRegulations();
        }

        public void refreshRegulations()
        {
            regulationList.Clear();
            regulations.Clear();
            regulationList = obtainRegulation();
            getRegulation();
        }

        

        //Rails
        public void getRails()
        {
            foreach (string[] items in railList)
            {
                int spoorNummer = Convert.ToInt32(items[0]);
                int sectorNummer = Convert.ToInt32(items[2]);

                Spoor spoor = new Spoor(spoorNummer, sectorNummer);
                rails.Add(spoor);
            }
        }

        public List<string[]> obtainRails()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("Rail_ID, Blocked, Sectors", "Rail");

            return returnvalue;
        }

        public void newRail()
        {

        }

        public void refreshRails()
        {
            railList.Clear();
            rails.Clear();
            railList = obtainRails();
            getRails();
        }


        //Trams

        public void getTrams()
        {
            foreach (string[] items in tramlist)
            {
                int tramNR = Convert.ToInt32(items[0]);
                int spoorNr = Convert.ToInt32(items[1]);
                string tramStatus = Convert.ToString(items[2]);
                int destination = Convert.ToInt32(items[3]);
                Tram tram = new Tram(tramNR, spoorNr, tramStatus, destination);
                trams.Add(tram);
            }
        }

        public List<string[]> obtainTrams()
        {
            List<string[]> returnvalue;
            returnvalue = DataCom.ReadAll("Tram_ID, Rail_ID, Tramstatus, Destination", "Tram");
            return returnvalue;
        }

        public void newTram(int tramNr, int spoorNr, string tramStatus, int bestemming)
        {
            Tram tram = new Tram(tramNr, spoorNr, tramStatus, bestemming);
            string addTram = "INSERT INTO Tram(Tram_ID, Rail_ID, Tramstatus, Destination) VALUES ('" + tramNr + "','" + spoorNr + "','" + tramStatus + "', '" + bestemming + "')";
            DataCom.nonQuery(addTram);
            refreshTram();
        }

        public void refreshTram()
        {
            tramlist.Clear();
            trams.Clear();
            tramlist = obtainTrams();
            getTrams();
        }

        //Schoonmaakplanning

        public void AddCleaning(string tramNR, string personeel, string datum, string duration)
        {
            //Insert a row to table
            string newCleaning = "INSERT INTO CLEANING_SCHEDULE(tram_id, user_id, time, duration) VALUES (" + tramNR + ", " + personeel + ", " + datum + ", " + duration + ");";
            DataCom.nonQuery(newCleaning);
        }

        public void RemoveCleaning(string tramNR)
        {
            //Delete a row from table
            string removeCleaning = "DELETE FROM CLEANING_SCHEDULE WHERE tram_id =" + tramNR + ";";
            DataCom.nonQuery(removeCleaning);
        }

        public List<string[]> CheckSchoonmaak()
        {
            //Search for all the trams that need to be cleaned
            return data1 = DataCom.ReadAll("c.Tram_id, c.User_ID, c.Time, c.Duration, t.Tramstatus", "Cleaning_Schedule c, Tram t", "c.Tram_ID = t.Tram_ID AND t.Tramstatus = 'Schoonmaak'");
        }

        //Techniekplanning

        public void AddRepair(string tramNR, string personeel, string datum, string duration)
        {
            //Insert a row to table
            string newRepair = "INSERT INTO MECHANIC_SCHEDULE(tram_id, user_id, time, duration) VALUES (" + tramNR + ", " + personeel + ", " + datum + ", " + duration + ");";
            DataCom.nonQuery(newRepair);
        }

        public void RemoveRepair(string tramNR)
        {
            //Delete a row from table
            string removeRepair = "DELETE FROM MECHANIC_SCHEDULE WHERE tram_id =" + tramNR + ";";
            DataCom.nonQuery(removeRepair);
        }

        public List<string[]> CheckTechniek()
        {
            //Search for all the trams that need to be repaired
            return data2 = DataCom.ReadAll("m.Tram_ID, m.User_ID, m.Time, m.Duration, t.Tramstatus", "Mechanic_Schedule m, Tram t", "t.Tram_ID = m.Tram_ID");
        }

        //TramSpecificaties
        public void onload(string tramnr)
        {
            tramclass = DataCom.Read("Tramstatus", "Tram", "Tram_ID = " + tramnr, "Tramstatus");
        }
        public void modify(string status, string tramnr)
        {
            DataCom.nonQuery("UPDATE Tram SET Tramstatus = " + "'" + status + "'" + " WHERE Tram_ID = " + tramnr);
        }
    }
}
