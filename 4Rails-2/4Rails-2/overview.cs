using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Overview
    {

        // Gebruikers
        private List<string[]> gebruikersList;
        public List<Gebruikers> gebruikers;

        //Sector
        private List<string[]> sectorList;
        public List<Sector> sectors;

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
        public string cleanidstring;

        //Techniek
        public List<string[]> data2 = new List<string[]>();

        //Trampspec
        public string tramclass;
        public string TramRails;
        public string TramSector;

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
            gebruikers = new List<Gebruikers>();
            gebruikersList = new List<string[]>();
            refreshDatabase();

        }

        public void refreshDatabase()
        {
            refreshSectors();
            refreshRegulations();
            refreshTram();
            refreshGebruikers();
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

            //leegmaken lijsten sectoren
            sectorList.Clear();
            sectors.Clear();

            sectorList = obtainSector();
            
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

            returnvalue = DataCom.ReadAll("RegelingID, TramID, RailID, userName, Tramstatus", "Regeling");

            return returnvalue;
        }

        public void newRegulation(int tramNr, int spoorNr, string User, string tramStatus)
        {
            regulations.Clear();
            string Number = DataCom.getCount();

                // Aantal regelingen tellen en dan +1 voor het nieuwe regelingID
                // Nog vervangen naar een max en dan +1
                int count = Convert.ToInt32(Number) + 1;

                string addRegulation = "INSERT INTO Regeling (RegelingID, TramID, RailID, userName, Tramstatus) VALUES(" + count + ", " + tramNr + ", " + spoorNr + ", '"+ User +"', '"+ tramStatus +"')";

                DataCom.nonQuery(addRegulation);

                //string update = "UPDATE Tram SET TramStatus= '" + tramStatus + "'," + "Rail_ID='" + spoorNr + "'" + " WHERE TramID ='" + tramNr + "')";
                //DataCom.nonQuery(update);
      


            refreshRegulations();
        }

        public void removeRegulation(int regelingsNr)
        {
            string removeRegulation = "Delete from Regeling Where RegelingID =" + regelingsNr;
            DataCom.nonQuery(removeRegulation);
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
                string control = Convert.ToString(items[1]);
                bool blocked = false;
                if (control == "Y")
                {
                    blocked = true;
                }
                Spoor spoor = new Spoor(spoorNummer, blocked);
                rails.Add(spoor);
            }
        }

        public List<string[]> obtainRails()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("RailID, Blocked", "Rail");

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
                int destination;
                if (items[3] == "")
                {
                    destination = spoorNr;
                }
                else
                {
                    destination = Convert.ToInt32(items[3]);
                }
                
                string tramType = Convert.ToString(items[4]);
                int sectorNr = Convert.ToInt32(items[5]);
                Tram tram = new Tram(tramNR, spoorNr, tramStatus, destination, tramType, sectorNr);
                trams.Add(tram);
            }
        }

        public List<string[]> obtainTrams()
        {
            List<string[]> returnvalue;
            returnvalue = DataCom.ReadAll("TramID, RailID, Tramstatus, Bestemming, Tramtype, SectorID", "Tram");
            return returnvalue;
        }

        public void newTram(int tramNr, int spoorNr, string tramStatus, int bestemming, string trampType, int sectorNR)
        {
            Tram tram = new Tram(tramNr, spoorNr, tramStatus, bestemming, trampType, sectorNR);
            string addTram = "INSERT INTO Tram(TramID, RailID, Tramstatus, Destination, Tramptype, sectorID) VALUES ('" + tramNr + "','" + spoorNr + "','" + tramStatus + "', '" + bestemming + "'," + trampType + "', '" + sectorNR + "')";
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

        public void AddCleaning(int cleanid, string tramNR, string personeel, string Tijdstart, string Tijdeind, string Beschrijving)
        {
            //Insert a row to table
            string newCleaning = "INSERT INTO Clean(cleanID, tramid, userid, TijdStart, TijdEind, Beschrijving) VALUES (" + cleanid + ", "+ tramNR + ", " + personeel + ", " + Tijdstart + ", " + Tijdeind + ", " + Beschrijving + ");";
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
            return data1 = DataCom.ReadAll("c.Tramid, c.UserID, c.TimeStart, c.TimeEnd, t.Tramstatus", "Clean c, Tram t", "c.TramID = t.TramID");
        }

        public string CheckClean()
        {
            return cleanidstring = DataCom.Read("MAX(CleanID)", "Clean", "CleanID");
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
            return data2 = DataCom.ReadAll("m.TramID, m.UserID, m.TimeStart, m.TimeEnd, t.Tramstatus, m.CanDrive", "Repair m, Tram t", "t.TramID = m.TramID");
        }

        //Gebruikers
        public void getGebruikers()
        {
            foreach (string[] items in gebruikersList)
            {
                string PersNaam = Convert.ToString(items[0]);
                int FunctieID = Convert.ToInt32(items[1]);

                Gebruikers gebruiker = new Gebruikers(FunctieID, PersNaam);
                gebruikers.Add(gebruiker);
            }
        }

        public List<string[]> obtainGebruikers()
        {
            List<string[]> returnvalue;

            returnvalue = DataCom.ReadAll("PersName, FunctionID", "Gebruiker");

            return returnvalue;
        }

        public void refreshGebruikers()
        {
            gebruikersList.Clear();
            gebruikers.Clear();
            gebruikersList = obtainGebruikers();
            getGebruikers();
        }

        //TramSpecificaties
        public void onload(string tramnr)
        {
            tramclass = DataCom.Read("Tramstatus", "Tram", "TramID = " + tramnr, "Tramstatus");
        }
        public void modify(string status, string tramnr, string railid, string railidnew, string sectorid, string sectoridnew)
        {
            DataCom.nonQuery("UPDATE Tram SET Tramstatus = " + "'" + status + "'" + " WHERE TramID = " + tramnr);
            DataCom.nonQuery("UPDATE Tram SET RailID = " + "'" + railidnew + "'" + " WHERE RailID = " + railid);
            DataCom.nonQuery("UPDATE Tram SET SectorID = " + "'" + sectoridnew + "'" + " WHERE SectorID = " + sectorid);
        }

        public string GetBeheerRails(string tramnr)
        {
            TramRails = DataCom.Read("RailID", "Tram", "TramID = " + tramnr, "RailID");
            return TramRails;
        }

        public string GetBeheerSector(string tramnr)
        {
            TramSector = DataCom.Read("RailID", "Tram", "TramID = " + tramnr, "RailID");
            return TramSector;
        }
    }
}
