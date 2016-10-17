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
            Event evenement;

            string name = null;
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Event_Exceptions_NameCannotBeSpaces()
        {
            //Arrange
            Event evenement;

            string name = "           ";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Event_Exceptions_LocationCannotBeNull()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = null;
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Event_Exceptions_LocationCannotBeSpaces()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "            ";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_StartDateCannotBeYesterday()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(-1); //Yeserday
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_StartDateCannotBeToday()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_EndDateCannotBeSoonerThanStartDate()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Yeserday
            DateTime end = DateTime.Today; //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_MaxVisitorsCannotBe0()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Yeserday
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 0;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_MaxVisitorsCannotBeNegative()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Yeserday
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = -1;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_CurrentVisitorsMayNotBeLessThan0()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Yeserday
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Act
            evenement.CurrentVisitors = -1;

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_CurrentVisitorsMayNotMoreThanMaximumVisitors()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Yeserday
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = new Camping("Intentsions", 500);

            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Act
            evenement.CurrentVisitors = 101;

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Event_Exceptions_PriceMayNotBeLessThan0()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = -1;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Event_Exceptions_CampingMayNotBeNull()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(2); //Day after tomorrow.
            int maximumVisitors = 100;
            decimal price = 27.95m;
            Camping camping = null;

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert is handled by the ExpectedException.
        }

        [TestMethod]
        public void Event_Constructor_AllSettingsMinimum()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(1); //Day after tomorrow.
            int maximumVisitors = 1;
            decimal price = 0;
            Camping camping = new Camping("Intentsions", 500);

            //Act
            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            //Assert
            Assert.IsTrue(evenement.MaxVisitors == 1);
            Assert.IsTrue(evenement.Price == 0);
            Assert.IsTrue(evenement.Name == "Landora");
            Assert.IsTrue(evenement.Location == "Awesomeville");
        }

        [TestMethod]
        public void Event_ToString()
        {
            //Arrange
            Event evenement;

            string name = "Landora";
            string location = "Awesomeville";
            DateTime start = DateTime.Today.AddDays(1); //Tomorrow.
            DateTime end = DateTime.Today.AddDays(1); //Day after tomorrow.
            int maximumVisitors = 1;
            decimal price = 0;
            Camping camping = new Camping("Intentsions", 500);

            evenement = new Event(name, location, start, end, maximumVisitors, price, camping);

            string date1 = start.ToString();
            string date2 = end.ToString();

            //Act
            string testString = evenement.ToString();
            
            //Assert
            Assert.IsTrue(testString == "Landora | Awesomeville | " + date1 + " | " + date2 + " | 1 | 0 | 0 | Intentsions");
        }
    }
}
