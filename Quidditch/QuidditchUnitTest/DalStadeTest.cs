using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidditchDataAccessLayerBaseDeDonnees;
using System.Collections.Generic;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalStadeTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllStadesIsNotNull()
        {
            IList<IStade> stades = dalProxy.GetAllStades();
            Assert.IsNotNull(stades);
        }

        [TestMethod]
        public void TestGetAllStadesGiveTypeStade()
        {
            IList<IStade> stades = dalProxy.GetAllStades();
            Assert.IsInstanceOfType(stades[0], typeof(IStade));
            Assert.IsNotNull(stades);
        }
    }
}
