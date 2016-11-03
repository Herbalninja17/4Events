//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EyeCT4Events;

//namespace EyeCT4Events_Testprojects
//{
//    [TestClass]
//    public class Camping_Tests
//    {

//        public void CampingSetUp(Camping Camping)
//        {
//            Camping.AddSpot(new CampingSpot(SpotType.Standard, 1, 2));
//            Camping.AddSpot(new CampingSpot(SpotType.Plus, 2, 4));
//            Camping.AddSpot(new CampingSpot(SpotType.Standard, 3, 2));
//            Camping.AddSpot(new CampingSpot(SpotType.VIP, 4, 2));
//            Camping.AddSpot(new CampingSpot(SpotType.VIP, 5, 3));
//            Camping.AddSpot(new CampingSpot(SpotType.Plus, 6, 6));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void Camping_Exceptions_NameCannotBeNull()
//        {
//            //Arrange
//            string name = null;
//            int places = 289;

//            //Act
//            Camping camping = new Camping(name, places);

//            //Assert is handled by the ExpectedException.
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Camping_Exceptions_NameCannotBeSpaces()
//        {
//            //Arrange
//            string name = "        ";
//            int places = 289;

//            //Act
//            Camping camping = new Camping(name, places);

//            //Assert is handled by the ExpectedException.
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void Camping_Exceptions_PlacesMayNotBe_0_OrLess()
//        {
//            //Arrange
//            string name = "Awesome ville";
//            int places = 0;

//            //Act
//            Camping camping = new Camping(name, places);

//            //Assert is handled by the ExpectedException.
//        }

//        [TestMethod]
//        public void Camping_AddSpot_SpotsCanBeAdded()
//        {
//            //Arrange
//            string name = "Awesome ville";
//            int places = 3;

//            Camping camping = new Camping(name, places);

//            CampingSpot spot1 = new CampingSpot(SpotType.Standard, 1, 2);
//            CampingSpot spot2 = new CampingSpot(SpotType.Plus, 2, 4);
//            CampingSpot spot3 = new CampingSpot(SpotType.Standard, 3, 2);

//            //Act
//            bool test1 = camping.AddSpot(spot1);
//            bool test2 = camping.AddSpot(spot2);
//            bool test3 = camping.AddSpot(spot3);

//            CampingSpot testSpot = camping.FindSpot(spot2);

//            //Assert
//            Assert.IsTrue(test1);
//            Assert.IsTrue(test2);
//            Assert.IsTrue(test3);
//            Assert.IsTrue(testSpot.SpotID == 2);
//        }

//        [TestMethod]
//        public void Camping_AddSpot_ExistingSpotsAreNotAdded()
//        {
//            //Arrange
//            string name = "Awesome ville";
//            int places = 3;

//            Camping camping = new Camping(name, places);

//            CampingSpot spot1 = new CampingSpot(SpotType.Standard, 1, 2);
//            CampingSpot spot2 = new CampingSpot(SpotType.Plus, 2, 4);
//            CampingSpot spot3 = new CampingSpot(SpotType.Standard, 1, 8);
//            CampingSpot spot4 = new CampingSpot(SpotType.Standard, 3, 2);

//            //Act
//            bool test1 = camping.AddSpot(spot1);
//            bool test2 = camping.AddSpot(spot2);
//            bool test3 = camping.AddSpot(spot3);
//            bool test4 = camping.AddSpot(spot4);

//            //Assert
//            Assert.IsTrue(camping.CampingSpots.Count == 3);
//            Assert.IsFalse(test3);
//        }

//        [TestMethod]
//        public void Camping_ModifySpot_ExistingSpotIsModified()
//        {
//            //Arrange
//            Camping Camping = new Camping("Awesome Ville", 6);
//            CampingSetUp(Camping);

//            CampingSpot modSpot = new CampingSpot(SpotType.VIP, 4, 3);
//            modSpot.Reserved = true;

//            //Act 1
//            CampingSpot testSpot = Camping.FindSpot(modSpot); //Searches by ID so it keeps the old values and not the modSpot values.

//            //Assert 1
//            Assert.IsTrue(testSpot.Capacity == 2);
//            Assert.IsFalse(testSpot.Reserved);

//            //Act 2
//            bool ModifyTest = Camping.ModifySpot(modSpot, modSpot);

//            //Assert 2
//            Assert.IsTrue(testSpot.Capacity == 3);
//            Assert.IsTrue(testSpot.Reserved);
//            Assert.IsTrue(ModifyTest);
//        }

//        [TestMethod]
//        public void Camping_ModifySpot_NoneExistingSpotIsNotModified()
//        {
//            //Arrange
//            Camping Camping = new Camping("Awesome Ville", 6);
//            CampingSetUp(Camping);

//            CampingSpot modSpot = new CampingSpot(SpotType.VIP, 36, 3);
//            modSpot.Reserved = true;

//            //Act
//            bool ModifyTest = Camping.ModifySpot(modSpot, modSpot);

//            //Assert
//            Assert.IsFalse(ModifyTest);
//        }

//        [TestMethod]
//        public void Camping_RemoveSpot_SpotIsRemoved()
//        {
//            //Arrange
//            Camping Camping = new Camping("Awesome Ville", 6);
//            CampingSetUp(Camping);

//            CampingSpot removeSpot = new CampingSpot(SpotType.Plus, 2, 4);

//            //Assert 1
//            Assert.IsTrue(Camping.CampingSpots.Count == 6);

//            //Act
//            bool ModifyTest = Camping.RemoveSpot(removeSpot);

//            //Assert 2
//            Assert.IsTrue(ModifyTest);
//            Assert.IsTrue(Camping.CampingSpots.Count == 5);
//            Assert.IsNull(Camping.FindSpot(removeSpot));
//        }

//        [TestMethod]
//        public void Camping_RemoveSpot_NotExistingSpotIsNotRemoved()
//        {
//            //Arrange
//            Camping Camping = new Camping("Awesome Ville", 6);
//            CampingSetUp(Camping);

//            CampingSpot removeSpot = new CampingSpot(SpotType.Plus, 41, 3);

//            //Assert 1
//            Assert.IsTrue(Camping.CampingSpots.Count == 6);

//            //Act
//            bool ModifyTest = Camping.RemoveSpot(removeSpot);

//            //Assert 2
//            Assert.IsFalse(ModifyTest);
//            Assert.IsTrue(Camping.CampingSpots.Count == 6);
//        }

//        [TestMethod]
//        public void Camping_FindSpot_SpotIsFound()
//        {
//            //Arrange
//            Camping Camping = new Camping("Awesome Ville", 6);
//            CampingSetUp(Camping);

//            CampingSpot testSpot = new CampingSpot(SpotType.Plus, 2, 4);

//            //Act
//            CampingSpot findTest = Camping.FindSpot(testSpot);

//            //Assert 2
//            Assert.IsTrue(findTest.SpotType == SpotType.Plus);
//            Assert.IsTrue(findTest.SpotID == 2);
//            Assert.IsTrue(findTest.Capacity == 4);
//        }

//        [TestMethod]
//        public void Camping_FindSpot_NotExistingSpotIsNull()
//        {
//            //Arrange
//            Camping Camping = new Camping("Awesome Ville", 6);
//            CampingSetUp(Camping);

//            CampingSpot testSpot = new CampingSpot(SpotType.Plus, 89, 4);

//            //Act
//            CampingSpot findTest = Camping.FindSpot(testSpot);

//            //Assert 2
//            Assert.IsNull(findTest);
//        }
//    }
//}
