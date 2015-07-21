using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QuidditchDataAccessLayerBaseDeDonnees;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalEquipeTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllEquipesIsNotNull()
        {
            IList<IEquipe> equipes = dalProxy.GetAllEquipes();
            Assert.IsNotNull(equipes);
        }

        [TestMethod]
        public void TestGetAllEquipesGiveTypeEquipe()
        {
            IList<IEquipe> equipes = dalProxy.GetAllEquipes();
            Assert.IsInstanceOfType(equipes[0], typeof(IEquipe));
            Assert.IsNotNull(equipes);
        }

        [TestMethod]
        public void TestGetAllEquipesWhereEquipesContainsJoueurs()
        {
            IList<IEquipe> equipes = dalProxy.GetAllEquipes();
            Assert.IsNotNull(equipes[0].Joueurs);
        }
    }
}
