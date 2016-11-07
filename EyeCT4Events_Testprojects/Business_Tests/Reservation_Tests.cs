using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Reservation_Tests
    {
        [TestMethod]
        public void Reservation_Constructor1_MinimumSettings()
        {
            //Arrange
            int ID = 0;
            bool running = false;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);

            //Act
            Reservation test = new Reservation(ID, running, spot);

            //Assert
            Assert.IsTrue(test.ReservationID == 0);
            Assert.IsTrue(test.CampingSpot.Price == 32);
        }

        [TestMethod]
        public void Reservation_Constructor2_MinimumSettings()
        {
            //Arrange
            DateTime startDate = DateTime.Today.AddDays(4);
            DateTime endDate = DateTime.Today.AddDays(5);

            //Act
            Reservation test = new Reservation(startDate, endDate);

            //Assert
            Assert.IsTrue(test.BeginDate == startDate);
            Assert.IsTrue(test.EndDate == endDate);
        }

        [TestMethod]
        public void Reservation_CalculateTotalPrice_PriceIsCalculated()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Reservation test = new Reservation(ID, spot);
            test.Materials.Add(mat1);
            test.Materials.Add(mat2);

            //Act
            decimal price = test.Price;

            //Assert
            Assert.IsTrue(price == 52);
        }
    }
}
