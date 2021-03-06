﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rails_2
{
    public class Regulation
    {
        public int regelingsID { get; set;}
        public int tramNr { get; set; }
        public int spoorNr { get; set; }
        public string User { get; set; }
        public string tramstatus { get; set; }

        public Regulation(int regelingsID, int tramNr, int spoorNr, string User, string tramstatus)
        {
            this.regelingsID = regelingsID;
            this.tramNr = tramNr;
            this.spoorNr = spoorNr;
            this.User = User;
            this.tramstatus = tramstatus;
        }

        public override string ToString()
        {
            return regelingsID + "\t\t\t" + tramNr + "\t\t\t" + spoorNr + "\t\t\t" + User + "\t\t\t" + tramstatus;
        }
    }
}
