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

        //BeheerClass
        public List<string[]> tramnrlist;

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

            returnvalue = DataCom.ReadAll("SectorID, RailID", "Sector");

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
                int regulationNr = Convert.ToInt32(items[0]);
                int tramNr = Convert.ToInt32(items[1]);
                int spoorNr = Convert.ToInt32(items[2]); 
                string user = Convert.ToString(items[3]);
                string tramstatus = Convert.ToString(items[4]);
                Regulation regulation = new Regulation(regulationNr, tramNr, spoorNr, user, tramstatus);
                regulations.Add(regulation);
            }
        }

        public List<string[]> obtainRegulation()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("r.TramID, Rail_ID, UserID, TramStatus", "Regeling r, Tram t", "r.TramID = t.TramID");

            return returnvalue;
        }

        public void newRegulation(int tramNr, int spoorNr, string User, string tramStatus)
        {
            regulations.Clear();
                string Number = DataCom.getCount();

                // Aantal regelingen tellen en dan +1 voor het nieuwe regelingID
                // nog vervangen naar een max en dan +1
                int count = Convert.ToInt32(Number) + 1;

             string addRegulation = "INSERT INTO Regulation(RegelingID, TramtramID, RailID, User, Tramstatus) VALUES ('" + count + "', '" + tramNr + "', '" + spoorNr + "', '" + User + "', '" + tramStatus + "')";

                DataCom.nonQuery(addRegulation);

                string update = "UPDATE Tram SET TramStatus= '" + tramStatus + "'," + "Rail_ID='" + spoorNr + "'" + " WHERE TramID ='" + tramNr + "')";
                DataCom.nonQuery(update);
      


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

            returnvalue = DataCom.ReadAll("RailID, Blocked, Sectors", "Rail");

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
            returnvalue = DataCom.ReadAll("TramID, RailID, Tramstatus, Destination", "Tram");
            return returnvalue;
        }

        public void newTram(int tramNr, int spoorNr, string tramStatus, int bestemming)
        {
            Tram tram = new Tram(tramNr, spoorNr, tramStatus, bestemming);
            string addTram = "INSERT INTO Tram(TramID, RailID, Tramstatus, Destination) VALUES ('" + tramNr + "','" + spoorNr + "','" + tramStatus + "', '" + bestemming + "')";
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

        //BeheerClass
        
        public void Beheerlist()
        {
            tramnrlist = DataCom.ReadAll("TramID, Tramstatus", "Tram");
        }
        //Schoonmaakplanning

        public void AddCleaning(string tramNR, string personeel, string datum, string duration)
        {
            //Insert a row to table
            string newCleaning = "INSERT INTO Clean(tramid, userid, time, duration) VALUES (" + tramNR + ", " + personeel + ", " + datum + ", " + duration + ");";
            DataCom.nonQuery(newCleaning);
        }

        public void RemoveCleaning(string tramNR)
        {
            //Delete a row from table
            string removeCleaning = "DELETE FROM Clean WHERE tramid =" + tramNR + ";";
            DataCom.nonQuery(removeCleaning);
        }

        public List<string[]> CheckSchoonmaak()
        {
            //Search for all the trams that need to be cleaned
            return data1 = DataCom.ReadAll("c.Tramid, c.UserID, c.Time, c.Duration, t.Tramstatus", "Clean c, Tram t", "c.TramID = t.TramID AND t.Tramstatus = 'Schoonmaak'");
        }

        //Techniekplanning

        public void AddRepair(string tramNR, string personeel, string datum, string duration)
        {
            //Insert a row to table
            string newRepair = "INSERT INTO Repair(tramid, userid, time, duration) VALUES (" + tramNR + ", " + personeel + ", " + datum + ", " + duration + ");";
            DataCom.nonQuery(newRepair);
        }

        public void RemoveRepair(string tramNR)
        {
            //Delete a row from table
            string removeRepair = "DELETE FROM Repair WHERE tramid =" + tramNR + ";";
            DataCom.nonQuery(removeRepair);
        }

        public List<string[]> CheckTechniek()
        {
            //Search for all the trams that need to be repaired
            return data2 = DataCom.ReadAll("m.TramID, m.UserID, m.Time, m.Duration, t.Tramstatus", "Repair m, Tram t", "t.TramID = m.TramID");
        }

        //TramSpecificaties
        public void onload(string tramnr)
        {
            tramclass = DataCom.Read("Tramstatus", "Tram", "TramID = " + tramnr, "Tramstatus");
        }
        public void modify(string status, string tramnr)
        {
            DataCom.nonQuery("UPDATE Tram SET Tramstatus = " + "'" + status + "'" + " WHERE TramID = " + tramnr);
        }
    }
}
