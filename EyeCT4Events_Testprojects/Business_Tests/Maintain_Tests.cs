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
            Person testPerson1 = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "Gotham", "0555-882244",
                                            "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person testPerson2 = new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                            "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321");
            Person testPerson3 = new Person("Dora", new DateTime(2001, 8, 12), "East Australian Current", "14WWC", "None", "0555-553344",
                                            "Fish@bigsea.oc", "Nemo1", "RABO 0 NL88 44368522");
            maintain.AddPerson(testPerson1);
            maintain.AddPerson(testPerson2);
            maintain.AddPerson(testPerson3);

        }

        public void TestReservations(Maintain maintain)
        {
            TestPersons(maintain);
            Person editPerson1 = maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            Person editPerson2 = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "Gotham", "0555-882244",
                                            "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person editPerson3 = new Person("Dora", new DateTime(2001, 8, 12), "East Australian Current", "14WWC", "None", "0555-553344",
                                            "Fish@bigsea.oc", "Nemo1", "RABO 0 NL88 44368522");

            CampingSpot spot1 = new CampingSpot(SpotType.Blokhut, 1, 101, 4, false, 28);
            CampingSpot spot2 = new CampingSpot(SpotType.Bungalow, 2, 202, 8, false, 30);
            CampingSpot spot3 = new CampingSpot(SpotType.Comfort, 3, 303, 4, false, 23);
            CampingSpot spot4 = new CampingSpot(SpotType.Eigen_tent, 4, 404, 5, false, 23);
            CampingSpot spot5 = new CampingSpot(SpotType.Blokhut, 5, 102, 4, false, 28);
            CampingSpot spot6 = new CampingSpot(SpotType.Invalide, 6, 505, 4, false, 28);


            Reservation testReservation1 = new Reservation(1, true, spot1);
            Reservation testReservation2 = new Reservation(2, false, spot2);
            Reservation testReservation3 = new Reservation(3, false, spot3);
            Reservation testReservation4 = new Reservation(1, false, spot4);
            Reservation testReservation5 = new Reservation(2, false, spot5);
            Reservation testReservation6 = new Reservation(1, true, spot6);

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
            Person testPerson = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "Gotham", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");

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
            Person testPerson = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "Gotham", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person testPerson2 = new Person("Not Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "Gotham", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");

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
            Person testPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            Person newPerson = new Person("Tony Stark", new DateTime(1979, 5, 18), "Baxter Building", "1134DD", "New York", "0555-66449955",
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
            Person testPerson = new Person("Peter Parker", new DateTime(1980, 7, 21), "Daily Bugle", "3333BC", "New Yrok", "0555-667714",
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
            Person removePerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
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
            Person removePerson = new Person("Peter Parker", new DateTime(1980, 7, 21), "Daily Bugle", "3333BC", "New York", "0555-667714",
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
            Person findPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
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
            Person findPerson = new Person("Peter Parker", new DateTime(1980, 7, 21), "Daily Bugle", "3333BC", "New York", "0555-667714",
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
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            //Act
            Person checkPerson = Maintain.FindPerson(editPerson);

            //Assert
            Assert.IsTrue(checkPerson.Reservations.Count == 3);
        }

        [TestMethod]
        public void Maintain_ModifyReservation_ReservationIsModified()
        {
            //Arrange 1
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            //Act 1
            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];

            //Assert 1
            Assert.IsTrue(checkReservation.CampingSpot.SpotID == 3);
            Assert.IsTrue(checkReservation.CampingSpot.SpotType == SpotType.Comfort);

            //Arrange 2
            CampingSpot newSpot = new CampingSpot(SpotType.Bungalino, 46, 538, 4, false, 32);
            Reservation modified = new Reservation(3, false, newSpot);

            //Act 2
            Maintain.ModifyReservation(checkPerson.Reservations[2], modified, checkPerson);
            checkPerson = Maintain.FindPerson(editPerson);
            checkReservation = checkPerson.Reservations[2];

            //Assert 2
            Assert.IsTrue(checkPerson.Reservations.Count == 3);
            Assert.IsTrue(checkReservation.CampingSpot.SpotID == 46);
            Assert.IsTrue(checkReservation.CampingSpot.SpotType == SpotType.Bungalino);
        }

        [TestMethod]
        public void Maintain_ModifyReservation_PersonDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            Person editPerson2 = new Person("Adam Sandler", new DateTime(1979, 5, 18), "Prisson", "3333BC", "Californië", "0555-667714",
                                                                 "Carrot@southpark.sp", "Schoolgirl180", "RABO 0 NL88 77553321");

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];

            //Act
            bool test = Maintain.ModifyReservation(checkReservation, checkReservation, editPerson2);

            //Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void Maintain_ModifyReservation_ReservationDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 49, 654, 4, false, 32);
            Reservation badReservation = new Reservation(78, false, spot);

            //Act
            bool test = Maintain.ModifyReservation(badReservation, checkReservation, editPerson);

            //Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void Maintain_DeleteReservation_ReservationIsRemoved()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];

            //Assert 1
            Assert.IsTrue(checkPerson.Reservations.Count == 3);

            //Act
            Maintain.DeleteReservation(checkReservation, checkPerson);

            //Assert 2
            Assert.IsTrue(checkPerson.Reservations.Count == 2);
        }

        [TestMethod]
        public void Maintain_DeleteReservation_PersonDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            Person editPerson2 = new Person("Adam Sandler", new DateTime(1979, 5, 18), "Prisson", "3333BC", "Californië", "0555-667714",
                                                                 "Carrot@southpark.sp", "Schoolgirl180", "RABO 0 NL88 77553321");

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];

            //Assert 1
            Assert.IsTrue(checkPerson.Reservations.Count == 3);

            //Act
            bool test = Maintain.DeleteReservation(checkReservation, editPerson2);

            //Assert 2
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void Maintain_DeleteReservation_ReservationDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 49, 654, 4, false, 32);
            Reservation badReservation = new Reservation(78, false, spot);

            //Act
            bool test = Maintain.DeleteReservation(badReservation, checkPerson);

            //Assert 2
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void Maintain_FindReservation_ReservationIsFound()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];

            //Act
            Reservation test = Maintain.FindReservation(checkReservation, checkPerson);

            //Assert 2
            Assert.IsTrue(test.CampingSpot.SpotID == 3);
        }

        [TestMethod]
        public void Maintain_FindReservation_PersonDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));
            Person editPerson2 = new Person("Adam Sandler", new DateTime(1979, 5, 18), "Prisson", "3333BC", "Californië", "0555-667714",
                                                                 "Carrot@southpark.sp", "Schoolgirl180", "RABO 0 NL88 77553321");

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];

            //Act
            Reservation test = Maintain.FindReservation(checkReservation, editPerson2);

            //Assert 2
            Assert.IsNull(test);
        }

        [TestMethod]
        public void Maintain_FindReservation_ReservationDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            TestReservations(Maintain);
            Person editPerson = Maintain.FindPerson(new Person("Tony Stark", new DateTime(1979, 5, 18), "Avenger Tower", "3333BC", "New York", "0555-667714",
                                                                 "Ironman@Avengers.org", "Pepper69", "RABO 0 NL88 77553321"));

            Person checkPerson = Maintain.FindPerson(editPerson);
            Reservation checkReservation = checkPerson.Reservations[2];
            CampingSpot spot = new CampingSpot(SpotType.Blokhut, 49, 654, 4, false, 32);
            Reservation badReservation = new Reservation(78, false, spot);

            //Act
            Reservation test = Maintain.FindReservation(badReservation, checkPerson);

            //Assert 2
            Assert.IsNull(test);
        }

        [TestMethod]
        public void Maintain_AddEvent_EventIsAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            //Act
            bool test = Maintain.AddEvent(Event);

            //Assert 2
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void Maintain_AddEvent_EventIsNotAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            Maintain.AddEvent(Event);

            //Act
            bool test = Maintain.AddEvent(Event);

            //Assert 2
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void Maintain_ModifyEvent_EventIsModified()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Event Event2 = new Event("Bad Kitty", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            Maintain.AddEvent(Event);
            Event testEvent = Maintain.Events[0];

            //Assert 1
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Wolf");

            //Act
            bool test = Maintain.ModifyEvent(Event, Event2);
            testEvent = Maintain.Events[0];

            //Assert 2
            Assert.IsTrue(test);
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Kitty");
        }

        [TestMethod]
        public void Maintain_ModifyEvent_EventDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Event Event2 = new Event("Bad Kitty", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            Maintain.AddEvent(Event);
            Event testEvent = Maintain.Events[0];

            //Assert 1
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Wolf");

            //Act
            bool test = Maintain.ModifyEvent(Event2, Event);
            testEvent = Maintain.Events[0];

            //Assert 2
            Assert.IsFalse(test);
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Wolf");
        }

        [TestMethod]
        public void Maintain_DeleteEvent_EventIsDeleted()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Event Event2 = new Event("Bad Kitty", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            Maintain.AddEvent(Event);
            Maintain.AddEvent(Event2);
            Event testEvent = Maintain.Events[1];

            //Assert 1
            Assert.IsTrue(Maintain.Events.Count == 2);
            Assert.IsTrue(testEvent.Name == "Bad Kitty");

            //Act
            bool test = Maintain.DeleteEvent(Event);
            testEvent = Maintain.Events[0];

            //Assert 2
            Assert.IsTrue(test);
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Kitty");
        }

        [TestMethod]
        public void Maintain_DeleteEvent_EventDoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Event Event2 = new Event("Bad Kitty", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            Maintain.AddEvent(Event);
            Event testEvent = Maintain.Events[0];

            //Assert 1
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Wolf");

            //Act
            bool test = Maintain.DeleteEvent(Event2);
            testEvent = Maintain.Events[0];

            //Assert 2
            Assert.IsFalse(test);
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsTrue(testEvent.Name == "Bad Wolf");
        }

        [TestMethod]
        public void Maintain_FindEvent_EventIsFound()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Event Event2 = new Event("Bad Kitty", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);

            Maintain.AddEvent(Event);
            Maintain.AddEvent(Event2);

            //Act
            Event test = Maintain.FindEvent(Event2);

            //Assert 2
            Assert.IsTrue(Maintain.Events.Count == 2);
            Assert.IsTrue(test.Name == "Bad Kitty");
        }

        [TestMethod]
        public void Maintain_FindEvent_DoesNotExist()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Event Event = new Event("Bad Wolf", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Event Event2 = new Event("Bad Kitty", DateTime.Today.AddDays(4), DateTime.Today.AddDays(8), camping);
            Maintain.AddEvent(Event2);

            //Act
            Event test = Maintain.FindEvent(Event);

            //Assert 2
            Assert.IsTrue(Maintain.Events.Count == 1);
            Assert.IsNull(test);
        }

        [TestMethod]
        public void Maintain_AddCamping_CampingIsAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Camping camping1 = new Camping(36, "DeltaFive", "greatsnorro", "bergville", "7878BL");
            Camping camping2 = new Camping(11, "Mexigrande", "petulia", "berglars", "0000GN");

            //Act
            Maintain.AddCamping(camping);
            Maintain.AddCamping(camping1);
            Maintain.AddCamping(camping2);
            Camping test = Maintain.Campings[1];

            //Assert 2
            Assert.IsTrue(Maintain.Campings.Count == 3);
            Assert.IsTrue(test.Name == "DeltaFive");
        }

        [TestMethod]
        public void Maintain_AddCamping_CampingAlreadyExists()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Camping camping = new Camping(15, "Derudo", "bakalakadakastreet", "GreatCity", "5874LOL");
            Camping camping1 = new Camping(36, "DeltaFive", "greatsnorro", "bergville", "7878BL");
            Camping camping2 = new Camping(11, "Mexigrande", "petulia", "berglars", "0000GN");

            Maintain.AddCamping(camping);
            Maintain.AddCamping(camping1);
            Maintain.AddCamping(camping2);

            //Act
            bool test = Maintain.AddCamping(camping2);
            Camping test2 = Maintain.Campings[1];

            //Assert 2
            Assert.IsFalse(test);
            Assert.IsTrue(Maintain.Campings.Count == 3);
            Assert.IsTrue(test2.Name == "DeltaFive");
        }
    }
}
