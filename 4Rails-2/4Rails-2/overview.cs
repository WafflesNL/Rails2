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


        public Overview()
        {
            trams = new List<Tram>();
            tramlist = new List<string[]>();
            rails = new List<Spoor>();
            railList = new List<string[]>();
            refreshDatabase();
        }

        public void refreshDatabase()
        {
            //refreshSectors();
            //refreshRegulations();
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

            returnvalue = DataCom.ReadAll("r.Tram_ID, Rail_ID, User_ID, TramStatus", "Regulation r, Tram t", "r.Tram_ID = t.Tram_ID");

            return returnvalue;
        }

        public void newRegulation(int tramNr, int spoorNr, string User, string tramStatus)
        {
            Regulation regulation = new Regulation(tramNr, spoorNr, User, tramStatus);
            string addRegulation = "INSERT INTO Regulation(Tram_ID, User) VALUES ('" + tramNr + "', '" + User + "'" + ")";
            DataCom.nonQuery(addRegulation);
            string update = "UPDATE Tram SET TramStatus= '" + tramStatus + "," + "Rail_ID='" + spoorNr + "'" + "' WHERE Tram_ID =" + tramNr + ")";
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
    }
}
