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

        
        public Overview()
        {
            regulationList = new List<string[]>();
            regulations = new List<Regulation>();
        }

        public void refreshDatabase()
        {
            //refreshSectors();
            refreshRegulations();
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
            string addRegulation = "INSERT INTO Regulation(Tram_ID, Rail_ID, User) VALUES ('" + tramNr + "', '" + spoorNr + "', " + "'" + User + "'" + ")";
            DataCom.nonQuery(addRegulation);
            string update = "UPDATE Tram SET TramStatus= '" + tramStatus + "' WHERE Tram_ID =" + tramNr + ")";
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

        }

        public List<string[]> obtainRails()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("Rail_ID, Blocked, Sectors", "Rail");

            return returnvalue;
        }

    }

    
}
