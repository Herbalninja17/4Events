using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class CampingSpot_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CampingSpot_SpotIDMayNotBeLessThan1()
        {
            //Arrange
            SpotType spotType = SpotType.Standard;
            int spotID = 0;
            int capacity = 1;

            //Act
            CampingSpot campingSpot = new CampingSpot(spotType, spotID, capacity);

            //Assert is handled by the ExcpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CampingSpot_CapacityMayNotBeLessThan1()
        {
            //Arrange
            SpotType spotType = SpotType.Standard;
            int spotID = 1;
            int capacity = 0;

            //Act
            CampingSpot campingSpot = new CampingSpot(spotType, spotID, capacity);

            //Assert is handled by the ExcpectedException
        }

        [TestMethod]
        public void CampingSpot_Constructor_AllSettingsMinimum()
        {
            //Arrange
            SpotType spotType = SpotType.Standard;
            int spotID = 1;
            int capacity = 1;

            //Act
            CampingSpot campingSpot = new CampingSpot(spotType, spotID, capacity);

            //Assert
            Assert.IsTrue(campingSpot.SpotType == SpotType.Standard);
            Assert.IsTrue(campingSpot.SpotID == 1);
            Assert.IsTrue(campingSpot.Capacity == 1);
            Assert.IsFalse(campingSpot.Reserved);
        }

        [TestMethod]
        public void CampingSpot_ReservationCanBeSet()
        {
            //Arrange
            SpotType spotType = SpotType.Standard;
            int spotID = 1;
            int capacity = 1;

            //Act 1
            CampingSpot campingSpot = new CampingSpot(spotType, spotID, capacity);

            //Assert 1
            Assert.IsFalse(campingSpot.Reserved);

            //Act 2
            campingSpot.Reserved = true;

            //Assert 2
            Assert.IsTrue(campingSpot.Reserved);
        }

        [TestMethod]
        public void CampingSpot_ToString()
        {
            //Arrange
            SpotType spotType = SpotType.Standard;
            int spotID = 1243;
            int capacity = 4;
            CampingSpot campingSpot = new CampingSpot(spotType, spotID, capacity);
            campingSpot.Reserved = true;

            //Act 1
            string testString = campingSpot.ToString();

            //Assert 1
            Assert.IsTrue(testString == "1243 | Standard | 4 | reserved");
        }
    }
}
