using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;
using System.Collections.Generic;

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

        [TestMethod]
        public void Reservation_OpenMaterialPayment_ListIsMadeCorrectlyMade()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Reservation test = new Reservation(ID, spot);

            Material mat1 = new Material(11, "USB", "2 Meter", 5, false, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, false, true);
            Material mat4 = new Material(14, "Scherm", "24 inch", 15, false, true);
            Material mat5 = new Material(15, "Powerbank", "3200 mHa", 5, true, true);

            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);
            test.Materials.Add(mat4);
            test.Materials.Add(mat5);

            //Act
            List<Material> testlist = test.OpenMaterialPayment();       

            //Assert
            Assert.IsTrue(testlist.Count == 3);
            Assert.IsTrue(testlist[0].Name == "USB");
            Assert.IsTrue(testlist[1].Name == "Muis");
            Assert.IsTrue(testlist[2].Name == "Scherm");
        }

        [TestMethod]
        public void Reservation_OpenMaterialPayment_EverythingIsPayed()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Reservation test = new Reservation(ID, spot);

            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);
            Material mat4 = new Material(14, "Scherm", "24 inch", 15, true, true);
            Material mat5 = new Material(15, "Powerbank", "3200 mHa", 5, true, true);

            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);
            test.Materials.Add(mat4);
            test.Materials.Add(mat5);

            //Act
            List<Material> testlist = test.OpenMaterialPayment();

            //Assert
            Assert.IsTrue(testlist.Count == 0);
        }

        [TestMethod]
        public void Reservation_CalculateOpenMaterialPayment_RightAmount()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Reservation test = new Reservation(ID, spot);

            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, false, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, false, true);
            Material mat4 = new Material(14, "Scherm", "24 inch", 15, false, true);
            Material mat5 = new Material(15, "Powerbank", "3200 mHa", 5, true, true);

            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);
            test.Materials.Add(mat4);
            test.Materials.Add(mat5);

            //Act
            decimal price = test.CalculateOpenMaterialPayment();

            //Assert
            Assert.IsTrue(price == 35);
        }

        [TestMethod]
        public void Reservation_CalculateOpenMaterialPayment_NothingHasToBePayed()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Reservation test = new Reservation(ID, spot);

            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);
            Material mat4 = new Material(14, "Scherm", "24 inch", 15, true, true);
            Material mat5 = new Material(15, "Powerbank", "3200 mHa", 5, true, true);

            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);
            test.Materials.Add(mat4);
            test.Materials.Add(mat5);

            //Act
            decimal price = test.CalculateOpenMaterialPayment();

            //Assert
            Assert.IsTrue(price == 0);
        }

        [TestMethod]
        public void Reservation_AddPerson_MaxPersonsAreAdded()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Person p3 = new Person("Roxanne", DateTime.Today.AddDays(-2600), "Maryl street", "1122NN", "testVille", "064433224411", "kroketje@shakeit.hot", "ww1", "ABC 123456789");
            Person p4 = new Person("Kristel", DateTime.Today.AddDays(-3000), "Maryl street", "1122NN", "testVille", "064433224411", "pannekoekie@shakeit.hot", "ww1", "ABC 123456789");
            Person p5 = new Person("Leo", DateTime.Today.AddDays(-3500), "Maryl street", "1122NN", "testVille", "064433224411", "kanonnetje@shakeit.hot", "ww1", "ABC 123456789");
            Person p6 = new Person("Erik", DateTime.Today.AddDays(-3400), "Maryl street", "1122NN", "testVille", "064433224411", "kabouterwouter@shakeit.hot", "ww1", "ABC 123456789");
            Person p7 = new Person("Martijn", DateTime.Today.AddDays(-3200), "Maryl street", "1122NN", "testVille", "064433224411", "crackert@shakeit.hot", "ww1", "ABC 123456789");
            Person p8 = new Person("Henk", DateTime.Today.AddDays(-1800), "Maryl street", "1122NN", "testVille", "064433224411", "vlekje@shakeit.hot", "ww1", "ABC 123456789");

            //Act 1
            int startcount = test.Persons.Count;

            //Assert 1
            Assert.IsTrue(startcount == 0);

            //Act 2
            test.AddPerson(p1);
            test.AddPerson(p2);
            test.AddPerson(p3);
            test.AddPerson(p4);
            test.AddPerson(p5);
            test.AddPerson(p6);
            test.AddPerson(p7);
            test.AddPerson(p8);

            startcount = test.Persons.Count;

            //Assert 2
            Assert.IsTrue(startcount == 8);
        }

        [TestMethod]
        public void Reservation_AddPerson_CannotAddSamePersonTwice()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Person p3 = new Person("Roxanne", DateTime.Today.AddDays(-2600), "Maryl street", "1122NN", "testVille", "064433224411", "kroketje@shakeit.hot", "ww1", "ABC 123456789");
            Person p4 = new Person("Kristel", DateTime.Today.AddDays(-3000), "Maryl street", "1122NN", "testVille", "064433224411", "pannekoekie@shakeit.hot", "ww1", "ABC 123456789");
            Person p5 = new Person("Leo", DateTime.Today.AddDays(-3500), "Maryl street", "1122NN", "testVille", "064433224411", "kanonnetje@shakeit.hot", "ww1", "ABC 123456789");
            Person p6 = new Person("Erik", DateTime.Today.AddDays(-3400), "Maryl street", "1122NN", "testVille", "064433224411", "kabouterwouter@shakeit.hot", "ww1", "ABC 123456789");
            Person p7 = new Person("Martijn", DateTime.Today.AddDays(-3200), "Maryl street", "1122NN", "testVille", "064433224411", "crackert@shakeit.hot", "ww1", "ABC 123456789");
            Person p8 = new Person("Henk", DateTime.Today.AddDays(-1800), "Maryl street", "1122NN", "testVille", "064433224411", "vlekje@shakeit.hot", "ww1", "ABC 123456789");

            //Act 1
            int startcount = test.Persons.Count;

            //Assert 1
            Assert.IsTrue(startcount == 0);

            //Act 2
            bool t1 = test.AddPerson(p1);
            bool t2 = test.AddPerson(p2);
            bool t3 = test.AddPerson(p3);
            bool t4 = test.AddPerson(p4);
            bool t5 = test.AddPerson(p5);
            bool t6 = test.AddPerson(p6);
            bool t7 = test.AddPerson(p2); //double
            bool t8 = test.AddPerson(p8);

            startcount = test.Persons.Count;

            //Assert 2
            Assert.IsTrue(startcount == 7);
            Assert.IsTrue(t1);
            Assert.IsTrue(t2);
            Assert.IsTrue(t3);
            Assert.IsTrue(t4);
            Assert.IsTrue(t5);
            Assert.IsTrue(t6);
            Assert.IsFalse(t7); //double
            Assert.IsTrue(t8);
        }

        [TestMethod]
        public void Reservation_AddPerson_CannotAddMoreThan8Persons()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Person p3 = new Person("Roxanne", DateTime.Today.AddDays(-2600), "Maryl street", "1122NN", "testVille", "064433224411", "kroketje@shakeit.hot", "ww1", "ABC 123456789");
            Person p4 = new Person("Kristel", DateTime.Today.AddDays(-3000), "Maryl street", "1122NN", "testVille", "064433224411", "pannekoekie@shakeit.hot", "ww1", "ABC 123456789");
            Person p5 = new Person("Leo", DateTime.Today.AddDays(-3500), "Maryl street", "1122NN", "testVille", "064433224411", "kanonnetje@shakeit.hot", "ww1", "ABC 123456789");
            Person p6 = new Person("Erik", DateTime.Today.AddDays(-3400), "Maryl street", "1122NN", "testVille", "064433224411", "kabouterwouter@shakeit.hot", "ww1", "ABC 123456789");
            Person p7 = new Person("Martijn", DateTime.Today.AddDays(-3200), "Maryl street", "1122NN", "testVille", "064433224411", "crackert@shakeit.hot", "ww1", "ABC 123456789");
            Person p8 = new Person("Henk", DateTime.Today.AddDays(-1800), "Maryl street", "1122NN", "testVille", "064433224411", "vlekje@shakeit.hot", "ww1", "ABC 123456789");
            Person p9 = new Person("Evira", DateTime.Today.AddDays(-3900), "Maryl street", "1122NN", "testVille", "064433224411", "wolkje@shakeit.hot", "ww1", "ABC 123456789");

            //Act 1
            int startcount = test.Persons.Count;

            //Assert 1
            Assert.IsTrue(startcount == 0);

            //Act 2
            bool t1 = test.AddPerson(p1);
            bool t2 = test.AddPerson(p2);
            bool t3 = test.AddPerson(p3);
            bool t4 = test.AddPerson(p4);
            bool t5 = test.AddPerson(p5);
            bool t6 = test.AddPerson(p6);
            bool t7 = test.AddPerson(p7); 
            bool t8 = test.AddPerson(p8);
            bool t9 = test.AddPerson(p9);

            startcount = test.Persons.Count;
            Console.WriteLine(startcount.ToString());

            //Assert 2
            Assert.IsTrue(startcount == 8);
            Assert.IsTrue(t1);
            Assert.IsTrue(t2);
            Assert.IsTrue(t3);
            Assert.IsTrue(t4);
            Assert.IsTrue(t5);
            Assert.IsTrue(t6);
            Assert.IsTrue(t7);
            Assert.IsTrue(t8);
            Assert.IsFalse(t9);
        }

        [TestMethod]
        public void Reservation_RemovePerson_PersonIsRemoved()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Person p3 = new Person("Roxanne", DateTime.Today.AddDays(-2600), "Maryl street", "1122NN", "testVille", "064433224411", "kroketje@shakeit.hot", "ww1", "ABC 123456789");
            Person p4 = new Person("Henk", DateTime.Today.AddDays(-3000), "Maryl street", "1122NN", "testVille", "064433224411", "pannekoekie@shakeit.hot", "ww1", "ABC 123456789");
            
            test.AddPerson(p1);
            test.AddPerson(p2);
            test.AddPerson(p3);
            test.AddPerson(p4);

            //Act 1
            int startcount = test.Persons.Count;

            //Assert 1
            Assert.IsTrue(startcount == 4);

            //Act 2
            bool t1 = test.RemovePerson(p3);

            startcount = test.Persons.Count;

            //Assert 2
            Assert.IsTrue(startcount == 3);
            Assert.IsTrue(t1);
        }

        [TestMethod]
        public void Reservation_RemovePerson_PersonDoesNotExist()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Person p3 = new Person("Roxanne", DateTime.Today.AddDays(-2600), "Maryl street", "1122NN", "testVille", "064433224411", "kroketje@shakeit.hot", "ww1", "ABC 123456789");
            Person p4 = new Person("Henk", DateTime.Today.AddDays(-3000), "Maryl street", "1122NN", "testVille", "064433224411", "pannekoekie@shakeit.hot", "ww1", "ABC 123456789");

            test.AddPerson(p1);
            test.AddPerson(p2);
            test.AddPerson(p4);

            //Act 1
            int startcount = test.Persons.Count;

            //Assert 1
            Assert.IsTrue(startcount == 3);

            //Act 2
            bool t1 = test.RemovePerson(p3);

            startcount = test.Persons.Count;

            //Assert 2
            Assert.IsTrue(startcount == 3);
            Assert.IsFalse(t1);
        }

        [TestMethod]
        public void Reservation_ToString_NoMaterialsLeased()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 4, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");

            test.AddPerson(p1);
            test.AddPerson(p2);

            //Act 1
            string teststring = test.ToString();

            //Assert 1
            Assert.IsTrue(teststring == "Reserverings ID: 0 | Personen: 2 | Geen materialen gehuurd");
        }

        [TestMethod]
        public void Reservation_ToString_3MaterialsLeased()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);
            test.BeginDate = DateTime.Today.AddDays(10);
            test.EndDate = DateTime.Today.AddDays(10);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);

            test.AddPerson(p1);
            test.AddPerson(p2);
            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);

            //Act 1
            string teststring = test.ToString();

            //Assert 1
            Assert.IsTrue(teststring == "Reserverings ID: 0 | Evenement start op " + test.BeginDate.ToString("d/M/yyyy") + " | Personen: 2 | Gehuurde materialen: USB, Tent, Muis");
        }

        [TestMethod]
        public void Reservation_ToString_EventIsRunning()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);
            test.EventIsRunning = true;

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);

            test.AddPerson(p1);
            test.AddPerson(p2);
            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);

            //Act 1
            string teststring = test.ToString();

            //Assert 1
            Assert.IsTrue(teststring == "Reserverings ID: 0 | Evenement loopt | Personen: 2 | Gehuurde materialen: USB, Tent, Muis");
        }

        [TestMethod]
        public void Reservation_ToString_EvenentHasNotYetStarted()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);
            test.BeginDate = DateTime.Today.AddDays(10);
            test.EndDate = DateTime.Today.AddDays(10);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);

            test.AddPerson(p1);
            test.AddPerson(p2);
            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);

            //Act 1
            string teststring = test.ToString();

            //Assert 1
            Assert.IsTrue(teststring == "Reserverings ID: 0 | Evenement start op " + test.BeginDate.ToString("d/M/yyyy") +" | Personen: 2 | Gehuurde materialen: USB, Tent, Muis");
        }

        [TestMethod]
        public void Reservation_ToString_NoStartDateAvailable_RunningIsFalse()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);

            test.AddPerson(p1);
            test.AddPerson(p2);
            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);

            //Act 1
            string teststring = test.ToString();            

            //Assert 1
            Assert.IsTrue(teststring == "Reserverings ID: 0 | Personen: 2 | Gehuurde materialen: USB, Tent, Muis");
        }

        [TestMethod]
        public void Reservation_ToString_EventIsOver()
        {
            //Arrange
            int ID = 0;
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 1, 1, 8, false, 32);
            Reservation test = new Reservation(ID, spot);
            test.BeginDate = DateTime.Today.AddDays(-1);

            Person p1 = new Person("Ben", DateTime.Today.AddDays(-2000), "Maryl street", "1122NN", "testVille", "064433224411", "banaantje@shakeit.hot", "ww1", "ABC 123456789");
            Person p2 = new Person("Amy", DateTime.Today.AddDays(-2500), "Maryl street", "1122NN", "testVille", "064433224411", "appeltje@shakeit.hot", "ww1", "ABC 123456789");
            Material mat1 = new Material(11, "USB", "2 Meter", 5, true, true);
            Material mat2 = new Material(12, "Tent", "4 persoons", 15, true, true);
            Material mat3 = new Material(13, "Muis", "Draadloos", 5, true, true);

            test.AddPerson(p1);
            test.AddPerson(p2);
            test.Materials.Add(mat1);
            test.Materials.Add(mat2);
            test.Materials.Add(mat3);

            //Act 1
            string teststring = test.ToString();

            //Assert 1
            Assert.IsTrue(teststring == "Reserverings ID: 0 | Evenement is voorbij | Personen: 2 | Gehuurde materialen: USB, Tent, Muis");
        }
    }
}
