using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuidditchUnitTest.QuidditchWebServices;
using System.Collections.Generic;

namespace QuidditchUnitTest
{
    [TestClass]
    public class ServiceReservationTest
    {
        private ServiceReservationClient serviceReservationClient;

        [TestInitialize]
        public void SetUp()
        {
            serviceReservationClient = new ServiceReservationClient();
        }

        [TestMethod]
        public void TestGetReservationForOneMatchNotNull()
        {
            IList<Reservation> reservations = new List<Reservation>();
            reservations = serviceReservationClient.GetReservationForOneMatch(0);
            Assert.IsNotNull(reservations);
        }

        [TestMethod]
        public void TestGetReservationForOneMatchGiveTypeReservation()
        {
            IList<Reservation> reservations = new List<Reservation>();
            reservations = serviceReservationClient.GetReservationForOneMatch(3);
            Assert.IsInstanceOfType(reservations[0], typeof(Reservation));
        }

        [TestMethod]
        public void TestAddReservationReturnsNoError()
        {
            Reservation reservation = new Reservation();
            reservation.Place = 1;
            reservation.Prix = 3.5f;
            int result = serviceReservationClient.AddReservation(reservation, 1);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestAddReservationOverbookMatchReturnsError()
        {
            Reservation reservation = new Reservation();
            reservation.Place = 455785;
            reservation.Prix = 2.75f;
            int result = serviceReservationClient.AddReservation(reservation, 0);
            Assert.AreEqual(result, -1);
        }
    }
}
