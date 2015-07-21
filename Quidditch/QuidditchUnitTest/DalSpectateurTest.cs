using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidditchDataAccessLayerBaseDeDonnees;
using System.Collections.Generic;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalSpectateurTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllSpectateursIsNotNull()
        {
            IList<ISpectateur> spectateurs = dalProxy.GetAllSpectateurs();
            Assert.IsNotNull(spectateurs);
        }

        [TestMethod]
        public void TestGetAllSpectateursGiveTypeSpectateur()
        {
            IList<ISpectateur> spectateurs = dalProxy.GetAllSpectateurs();
            Assert.IsInstanceOfType(spectateurs[0], typeof(ISpectateur));
            Assert.IsNotNull(spectateurs);
        }
    }
}
