using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Maintain_Tests
    {
        public void TestPersons(Maintain maintain)
        {
            Person testPerson1 = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244",
                                            "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person testPerson2 = new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "0555-667714",
                                            "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321");
            Person testPerson3 = new Person("Dora", new DateTime(2001, 8, 12), "East Australian Current", "14WWC", "0555-553344",
                                            "Fish@bigsea.oc", "Nemo1", "RABO 0 NL88 44368522");
            maintain.AddPerson(testPerson1);
            maintain.AddPerson(testPerson2);
            maintain.AddPerson(testPerson3);

        }

        public void TestReservations(Maintain maintain)
        {
            TestPersons(maintain);
            Person editPerson1 = maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            Person editPerson2 = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244",
                                            "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person editPerson3 = new Person("Dora", new DateTime(2001, 8, 12), "East Australian Current", "14WWC", "0555-553344",
                                            "Fish@bigsea.oc", "Nemo1", "RABO 0 NL88 44368522");


            Reservation testReservation1 = new Reservation(1, true);
            Reservation testReservation2 = new Reservation(2, false);
            Reservation testReservation3 = new Reservation(3, false);

            Reservation testReservation4 = new Reservation(1, false);
            Reservation testReservation5 = new Reservation(2, false);

            Reservation testReservation6 = new Reservation(1, true);

            maintain.AddReservationToPerson(testReservation1, editPerson1);
            maintain.AddReservationToPerson(testReservation2, editPerson1);
            maintain.AddReservationToPerson(testReservation3, editPerson1);
            maintain.AddReservationToPerson(testReservation4, editPerson2);
            maintain.AddReservationToPerson(testReservation5, editPerson2);
            maintain.AddReservationToPerson(testReservation6, editPerson2);
        }

        [TestMethod]
        public void Maintain_AddPerson_PersonIsAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Person testPerson = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");

            //Assert1
            Assert.IsTrue(Maintain.Persons.Count == 0);

            //Act
            Maintain.AddPerson(testPerson);
            Person check = Maintain.FindPerson(testPerson);

            //Assert 2
            Assert.IsTrue(Maintain.Persons.Count == 1);
            Assert.IsNotNull(check);
        }

        [TestMethod]
        public void Maintain_AddPerson_ExistingPersonIsNotAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Person testPerson = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person testPerson2 = new Person("Not Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");

            //Act 1
            Maintain.AddPerson(testPerson);

            //Assert 1
            Assert.IsTrue(Maintain.Persons.Count == 1);

            //Act 2
            Person check = Maintain.FindPerson(testPerson);
            bool testAdd = Maintain.AddPerson(testPerson2);

            //Assert 2
            Assert.IsTrue(Maintain.Persons.Count == 1);
            Assert.IsFalse(testAdd);
            Assert.IsTrue(check.Name == "Bruce Banner");
        }

        [TestMethod]
        public void Maintain_ModifyPerson_PersonIsModified()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestPersons(Maintain);
            Person testPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "0555-667714",
                                                                "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            Person newPerson = new Person("Tony Stark", new DateTime(1979, 5, 18), "Baxter Building", "1134DD", "0555-66449955",
                                                                "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321");

            //Act 1
            int index = Maintain.Persons.IndexOf(testPerson);
            Person checkPerson = Maintain.FindPerson(testPerson);

            //Assert 1
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsTrue(index == 1);
            Assert.IsTrue(checkPerson.Address == "Avenger Tower");

            //Act 2
            bool check = Maintain.ModifyPerson(testPerson, newPerson);
            int index2 = Maintain.Persons.IndexOf(newPerson);
            checkPerson = Maintain.FindPerson(newPerson);

            //Assert 2
            Assert.IsTrue(check);
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsTrue(index == index2);
            Assert.IsTrue(checkPerson.Address == "Baxter Building");
        }

        [TestMethod]
        public void Maintain_ModifyPerson_PersonDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestPersons(Maintain);
            Person testPerson = new Person("Peter Parker", new DateTime(1980, 7, 21), "Daily Bugle", "3333BC", "0555-667714",
                                           "Friendly@Neighbourhood.sp", "MarryJane69", "RABO 0 NL88 7946138246");

            //Act 1
            bool check = Maintain.ModifyPerson(testPerson, testPerson);

            //Assert 1
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void Maintain_RemovePerson_PersonIsRemoved()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestPersons(Maintain);
            Person removePerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            //Act 1
            Person checkPerson = Maintain.FindPerson(removePerson);

            //Assert 1
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsTrue(checkPerson.Address == "Avenger Tower");

            //Act 2
            bool check = Maintain.RemovePerson(removePerson);
            checkPerson = Maintain.FindPerson(removePerson);

            //Assert 2
            Assert.IsTrue(check);
            Assert.IsTrue(Maintain.Persons.Count == 2);
            Assert.IsNull(checkPerson);
        }

        [TestMethod]
        public void Maintain_RemovePerson_PersonDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestPersons(Maintain);
            Person removePerson = new Person("Peter Parker", new DateTime(1980, 7, 21), "Daily Bugle", "3333BC", "0555-667714",
                                             "Friendly@Neighbourhood.sp", "MarryJane69", "RABO 0 NL88 7946138246");

            //Act 1
            Person checkPerson = Maintain.FindPerson(removePerson);

            //Assert 1
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsNull(checkPerson);

            //Act 2
            bool check = Maintain.RemovePerson(removePerson);

            //Assert 2
            Assert.IsFalse(check);
            Assert.IsTrue(Maintain.Persons.Count == 3);
        }

        [TestMethod]
        public void Maintain_FindPerson_PersonIsFound()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestPersons(Maintain);
            Person findPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            //Act
            Person checkPerson = Maintain.FindPerson(findPerson);

            //Assert
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsTrue(checkPerson.Address == "Avenger Tower");
        }

        [TestMethod]
        public void Maintain_FindPerson_PersonDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestPersons(Maintain);
            Person findPerson = new Person("Peter Parker", new DateTime(1980, 7, 21), "Daily Bugle", "3333BC", "0555-667714",
                                             "Friendly@Neighbourhood.sp", "MarryJane69", "RABO 0 NL88 7946138246");

            //Act
            Person checkPerson = Maintain.FindPerson(findPerson);

            //Assert
            Assert.IsTrue(Maintain.Persons.Count == 3);
            Assert.IsNull(checkPerson);
        }

        [TestMethod]
        public void Maintain_AddReservationToPerson_ReservationIsAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            //Act
            Person checkPerson = Maintain.FindPerson(editPerson);

            //Assert
            Assert.IsTrue(checkPerson.Reservations.Count == 3);
        }

        //ER WORD NIET GECONTROLLEERD OP RESERVATION ID - MOET AANGEPAST WORDEN. ALLE RESERVATIONS UNIEK? RESERVATIONS BIJ PERSOON UNIEK?
                                                                                        //EN HOE WORD DE TELLING DAN GEREGELD.
    }
}
