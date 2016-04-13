using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oracle.ManagedDataAccess.Client;

namespace _4Rails_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DataComTest()
        {
            DataCom.ConnectToDB();
            Assert.IsNotNull(DataCom.Connection, "rip");
            //DataCom.nonQuery("INSERT INTO spoor (spoornr, blocked, aantalsectoren) VALUES (2, 0, 1)");
            string temp = DataCom.Read("spoornr", "spoor", "spoornr = 1", "spoornr");
            Assert.AreEqual("1", temp, "rip");
        }
    }
}
