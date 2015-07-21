using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidditchDataAccessLayerBaseDeDonnees;
using System.Collections.Generic;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalMatchTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllMatchesIsNotNull()
        {
            IList<IMatch> matches = dalProxy.GetAllMatches();
            Assert.IsNotNull(matches);
        }

        [TestMethod]
        public void TestGetAllMatchesGiveTypeMatch()
        {
            IList<IMatch> matches = dalProxy.GetAllMatches();
            Assert.IsInstanceOfType(matches[0], typeof(IMatch));
            Assert.IsNotNull(matches);
        }

        [TestMethod]
        public void TestGetAllMatchesWithMatchesContainsAllObjectsEncapsulated()
        {
            IList<IMatch> matches = dalProxy.GetAllMatches();
            Assert.IsNotNull(matches[0].EquipeDomicile);
            Assert.IsNotNull(matches[0].EquipeDomicile.Joueurs[0]);
            Assert.IsNotNull(matches[0].EquipeVisiteur);
            Assert.IsNotNull(matches[0].EquipeVisiteur.Joueurs[0]);
            Assert.IsNotNull(matches[0].ReservationsPourLeMatch);
            Assert.IsNotNull(matches[0].ArbitreDuMatch);
            Assert.IsNotNull(matches[0].StadeDuMatch);
        }

        
        

        
        

        
    }
}
