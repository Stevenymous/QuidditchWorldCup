using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QuidditchDataAccessLayerBaseDeDonnees;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalCoupeTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllCoupesIsNotNull()
        {
            IList<ICoupe> coupes = dalProxy.GetAllCoupes();
            Assert.IsNotNull(coupes);
        }

        [TestMethod]
        public void TestGetAllCoupesGiveTypeCoupe()
        {
            IList<ICoupe> coupes = dalProxy.GetAllCoupes();
            Assert.IsInstanceOfType(coupes[0], typeof(ICoupe));
            Assert.IsNotNull(coupes);
        }

        [TestMethod]
        public void TestGetAllCoupesWhereCoupesContainsMatches()
        {
            IList<ICoupe> coupes = dalProxy.GetAllCoupes();
            Assert.IsNotNull(coupes[0].Matches);
        }
    }
}
