using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidditchUnitTest.QuidditchWebServices;
using System.Collections.Generic;

namespace QuidditchUnitTest
{
    [TestClass]
    public class ServiceMatchTest
    {
        private ServiceMatchClient serviceMatchClient;

        [TestInitialize]
        public void SetUp()
        {
            serviceMatchClient = new ServiceMatchClient();
        }

        [TestMethod]
        public void TestGetAllMatchesIsNotNull()
        {
            IList<Match> matches = new List<Match>();
            matches = serviceMatchClient.GetAllMatches();
            Assert.IsNotNull(matches);
        }

        [TestMethod]
        public void TestGetAllMatchesContainsMatches()
        {
            IList<Match> matches = new List<Match>();
            matches = serviceMatchClient.GetAllMatches();
            Assert.IsInstanceOfType(matches[0], typeof(Match));
        }
    }
}
