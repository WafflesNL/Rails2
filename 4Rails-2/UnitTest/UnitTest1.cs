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
            
            string username = "Bart";
            List<string[]> temp = DataCom.ReadAll("password, function_id", "user_", "username = " + "'" + username + "'");
            Assert.AreEqual("123", temp[0][0]);
            Assert.AreEqual("1", temp[0][1]);

            DataCom.Close();
        }
    }
}
