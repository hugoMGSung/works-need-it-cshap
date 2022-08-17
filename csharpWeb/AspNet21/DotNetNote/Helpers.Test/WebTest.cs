using DotNetNote.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Helpers.Test
{
    [TestClass]
    public class WebTest
    {
        [Ignore]
        [TestMethod]
        public void IsCorrectSqlConnection()
        {
            var res = new DbRepository();
            //Assert.IsNotNull(res.con, "SqlConnection must not be null.");
        }
    }
}
