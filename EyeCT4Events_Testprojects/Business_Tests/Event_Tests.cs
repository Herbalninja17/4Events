using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Event_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Event_Exceptions_NameCannotBeNull()
        {
            //Arrange
            Event Event;

            string name = null;
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            //Act
            Event = new Event(name, start, end, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Event_Exceptions_NameCannotBeSpaces()
        {
            //Arrange
            Event Event;

            string name = "           ";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            //Act
            Event = new Event(name, start, end, camping);

            //Assert is handled by the ExpectedException.
        }       

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_StartDateCannotBeYesterday()
        {
            //Arrange
            Event Event;

            string name = "Landora";
            DateTime start = DateTime.Today.AddDays(-1); //Yeserday
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            //Act
            Event = new Event(name, start, end, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_StartDateCannotBeToday()
        {
            //Arrange
            Event Event;

            string name = "Landora";
            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            //Act
            Event = new Event(name, start, end, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_EndDateCannotBeSoonerThanStartDate()
        {
            //Arrange
            Event Event;

            string name = "Landora";
            DateTime start = DateTime.Today.AddDays(1); //Yeserday
            DateTime end = DateTime.Today; //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            //Act
            Event = new Event(name, start, end, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Event_Exceptions_CampingMayNotBeNull()
        {
            //Arrange
            Event Event;

            string name = "Landora";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            Camping camping = null;

            //Act
            Event = new Event(name, start, end, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        public void Event_Constructor_AllSettingsMinimum()
        {
            //Arrange
            Event Event;

            string name = "Landora";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(1); //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            //Act
            Event = new Event(name, start, end, camping);

            //Assert
            Assert.IsTrue(Event.Name == "Landora");
            Assert.IsTrue(Event.Camping.Name == "Awesomeville");
            Assert.IsTrue(Event.StartDate == DateTime.Today.AddDays(1));
            Assert.IsTrue(Event.EndDate == DateTime.Today.AddDays(1));
        }

        [TestMethod]
        public void Event_ToString()
        {
            //Arrange
            Event Event;

            string name = "Landora";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(1); //Day after tomorrow.
            Camping camping = new Camping(101, "Awesomeville", "Longroad66", "Greatwood", "6969SX");

            Event = new Event(name, start, end, camping);

            string date1 = start.ToString("d-M-yyyy");
            string date2 = end.ToString("d-M-yyyy");

            //Act
            string testString = Event.ToString();

            //Assert
            Assert.IsTrue(testString == "Landora | " + date1 + " | " + date2 + " | 0 | 0 | Awesomeville");
        }
    }
}
