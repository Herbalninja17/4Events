//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EyeCT4Events;

//namespace EyeCT4Events_Testprojects.Business_Tests
//{
//    [TestClass]
//    public class Reservation_Tests
//    {
//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void Reservation_ReservationIDMayNotBeZero()
//        {
//            //Arrange
//            int ID = 0;
//            bool play = false;

//            //Act
//            Reservation r = new Reservation(ID, play);

//            //Assert is handles by ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void Reservation_ReservationIDMayNotBeLowerThanZero()
//        {
//            //Arrange
//            int ID = -1;
//            bool play = false;

//            //Act
//            Reservation r = new Reservation(ID, play);

//            //Assert is handled by ExcpectedException
//        }
//    }
//}
