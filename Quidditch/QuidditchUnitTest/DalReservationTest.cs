using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QuidditchDataAccessLayerBaseDeDonnees;

namespace QuidditchUnitTest
{
    [TestClass]
    public class DalReservationTest
    {
        private DalProxy dalProxy;

        [TestInitialize]
        public void SetUp()
        {
            dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
        }

        [TestMethod]
        public void TestGetAllReservationsIsNotNull()
        {
            IList<IReservation> reservations = dalProxy.GetAllReservations();
            Assert.IsNotNull(reservations);
        }

        [TestMethod]
        public void TestGetAllReservationsGiveTypeReservation()
        {
            IList<IReservation> reservations = dalProxy.GetAllReservations();
            Assert.IsInstanceOfType(reservations[0], typeof(IReservation));
            Assert.IsNotNull(reservations);
        }

        [TestMethod]
        public void TestGetReservationsForOneMatchIsNotNull()
        {
            IList<IReservation> reservations = dalProxy.GetReservationForOneMatch(3);
            Assert.IsNotNull(reservations);
        }

        [TestMethod]
        public void TestGetReservationsForOneMatchGiveTypeReservation()
        {
            IList<IReservation> reservations = dalProxy.GetReservationForOneMatch(3);
            Assert.IsInstanceOfType(reservations[0], typeof(IReservation));
            Assert.IsNotNull(reservations);
        }
    }
}
