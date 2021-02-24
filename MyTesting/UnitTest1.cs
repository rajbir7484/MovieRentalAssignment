using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalAssignment.DataAccessLayer;
using MovieRentalAssignment.Utility;

namespace MyTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SqlConnection DbCon = DataBaseConnection.OpenConnection();
            bool status = DbCon != null;
            Assert.AreEqual(true, status);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int days = new CalculateDays().GetTotalDays("15-02-2021", "20-02-2021");
            int expectedvalue = 5;
            Assert.AreEqual(expectedvalue,days);
        }
    }
}
