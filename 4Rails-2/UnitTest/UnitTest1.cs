using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

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
            /*
            //DataCom.nonQuery("INSERT INTO rail (rail_id, blocked, sectors) VALUES (1, 0, 1)");
            //string temp = DataCom.Read("rail_id", "rail", "rail_id = 1", "rail_id");
            //Assert.AreEqual("1", temp, "rip");
            string[] temp2 = new string[2] { "rail_id", "sectors" };
            //string[] temp2 = new string[1] { "rail_id" };
            string[] temp3 = DataCom.Read("rail_id, sectors", "rail", "rail_id = 1", temp2);
            Assert.IsNotNull(temp3);
            Assert.AreEqual("1", temp3[0], "rip");
            Assert.AreEqual("1", temp3[1], "rip");
            */

            string[] columns = new string[2] { "password", "function_id" };
            string[] columns2 = new string[1] { "password" };
            //string[] temp = DataCom.Read("password, functie_id", "user_", "username = " + "'" + "Bart" + "'", columns2);
            string username = "Bart";
            List<string[]> temp = DataCom.ReadAll("password, function_id", "user", "username = " + "'" + username + "'", columns);
            Assert.AreEqual("123", temp[0][0]);
            Assert.AreEqual("1", temp[0][1]);
        }
    }
}
