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
        }
    }
}
