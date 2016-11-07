using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;
using System.Collections.Generic;

namespace EyeCT4Events_Testprojects
{
    /// <summary>
    /// All data for this class comes from the database.
    /// Exceptions for variables will be caught in the datalayer
    /// for this class.
    /// </summary>
    [TestClass]
    public class Camping_Tests
    {
        /// <summary>
        /// Used to setup a camping with testable content.
        /// </summary>
        /// <param name="camping"></param>
        public void CampingSetUp(Camping camping)
        {
            camping.CampingSpots.Clear(); //We clear the database values and create a controlled set of camping spots to test with.

            camping.CampingSpots.Add(new CampingSpot(SpotType.Blokhut, 1, 101, 4, true, 28));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Blokhut, 2, 102, 4, false, 28));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Eigen_tent, 3, 211, 5, true, 15));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Eigen_tent, 4, 212, 5, false, 15));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Huurtent, 5, 321, 4, true, 18));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Huurtent, 6, 322, 4, false, 18));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Comfort, 7, 431, 4, true, 20));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Comfort, 8, 432, 4, false, 20));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Stacaravan, 9, 541, 6, true, 22));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Stacaravan, 10, 542, 6, false, 22));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Invalide, 11, 651, 4, true, 20));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Invalide, 12, 652, 4, false, 20));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Bungalow, 13, 761, 8, true, 30));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Bungalow, 14, 762, 8, false, 30));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Bungalino, 15, 871, 4, true, 28));
            camping.CampingSpots.Add(new CampingSpot(SpotType.Bungalino, 16, 872, 4, false, 28));

        }

        [TestMethod]
        public void Camping_this_CampingSetUp()
        {
            //Arrange
            Camping Camping = new Camping(101, "Awesomeville", "Longroad66","Greatwood", "6969SX");

            //Act
            CampingSetUp(Camping);

            //Assert
            Assert.IsTrue(Camping.Places == 16);
        }

        [TestMethod]
        public void Camping_FreeCampingSpots_WithSpotType()
        {
            //Arrange
            Camping Camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");
            CampingSetUp(Camping);

            List<CampingSpot> checkSpots = new List<CampingSpot>();
            CampingSpot spot = null;

            //Act
            checkSpots = Camping.FreeCampingSpots(SpotType.Blokhut);
            foreach(CampingSpot found in checkSpots)
            {
                spot = found;
            }

            //Assert
            Assert.IsTrue(checkSpots.Count == 1);
            Assert.IsTrue(spot.SpotType == SpotType.Blokhut);
            Assert.IsFalse(spot.Reserved);
            Assert.IsTrue(spot.SpotID == 2);
        }

        [TestMethod]
        public void Camping_FreeCampingSpots_NoSpotType()
        {
            //Arrange
            Camping Camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");
            CampingSetUp(Camping);

            List<CampingSpot> checkSpots = new List<CampingSpot>();
            CampingSpot spot = null;

            //Act
            checkSpots = Camping.FreeCampingSpots();
            spot = checkSpots[2]; //This should be the second Huurtend in the CampingSetUp();

            //Assert
            Assert.IsTrue(checkSpots.Count == 8);
            Assert.IsTrue(spot.SpotType == SpotType.Huurtent);
            Assert.IsFalse(spot.Reserved);
            Assert.IsTrue(spot.SpotID == 6);
        }

        [TestMethod]
        public void Camping_ReservedCampingSpots()
        {
            //Arrange
            Camping Camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");
            CampingSetUp(Camping);

            List<CampingSpot> checkSpots = new List<CampingSpot>();
            CampingSpot spot = null;

            //Act
            checkSpots = Camping.ReservedCampingSpots();
            spot = checkSpots[4]; //This should be the first Stacaravan in the CampingSetUp();

            //Assert
            Assert.IsTrue(checkSpots.Count == 8);
            Assert.IsTrue(spot.SpotType == SpotType.Stacaravan);
            Assert.IsTrue(spot.Reserved);
            Assert.IsTrue(spot.SpotID == 9);
        }
    }
}
