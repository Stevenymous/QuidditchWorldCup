using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidditchDataAccessLayerBaseDeDonnees;
using System.Collections.Generic;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalJoueurTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllJoueursIsNotNull()
        {
            IList<IJoueur> joueurs = dalProxy.GetAllJoueurs();
            Assert.IsNotNull(joueurs);
        }

        [TestMethod]
        public void TestGetAllJoueursGiveTypeJoueur()
        {
            IList<IJoueur> joueurs = dalProxy.GetAllJoueurs();
            Assert.IsInstanceOfType(joueurs[6], typeof(IJoueur));
            Assert.IsNotNull(joueurs);
        }

    }
}
