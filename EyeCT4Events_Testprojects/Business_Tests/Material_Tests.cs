using System;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Material_Tests
    {

        [TestMethod]
        public void Material_Constructor_AllSettingsMinimum()
        {
            //Arrange
            int id = 0;
            string name = "SpyCam";
            string description = "3 cm";
            decimal price = 0.01m;
            bool isPayed = false;
            bool isLeased = false;

            //Act
            Material material = new Material(id, name, description, price, isPayed, isLeased);

            //Assert
            Assert.IsTrue(material.ID == 0);
            Assert.IsTrue(material.Price == 0.01m);
            Assert.IsTrue(material.Name == "SpyCam");
            Assert.IsTrue(material.Description == "3 cm");
            Assert.IsFalse(material.IsPayed);
            Assert.IsFalse(material.Leased);
        }

        [TestMethod]
        public void Material_StartLease()
        {
            //Arrange
            int id = 0;
            string name = "SpyCam";
            string description = "3 cm";
            decimal price = 0.01m;
            bool isPayed = false;
            bool isLeased = false;
            Material material = new Material(id, name, description, price, isPayed, isLeased);
            DateTime endLease = DateTime.Today.AddDays(2);

            //Act
            material.StartLease(endLease);

            //Assert
            Assert.IsTrue(material.LeaseDateStart == DateTime.Today);
            Assert.IsTrue(material.LeaseDateEnd == DateTime.Today.AddDays(2));
            Assert.IsTrue(material.Leased);
        }

        [TestMethod]
        public void Material_StopLease()
        {
            //Arrange
            int id = 0;
            string name = "SpyCam";
            string description = "3 cm";
            decimal price = 0.01m;
            bool isPayed = false;
            bool isLeased = false;
            Material material = new Material(id, name, description, price, isPayed, isLeased);
            DateTime endLease = DateTime.Today.AddDays(2);

            //Act 1
            material.StartLease(endLease);

            //Assert 1
            Assert.IsTrue(material.Leased);

            //Act 2
            material.StopLease();

            //Assert 2
            Assert.IsFalse(material.Leased);
        }

        [TestMethod]
        public void Material_ToString()
        {
            //Arrange
            Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL"); //In sommige systemen komt de prijs met een punt i.p.v een komma
                                                                            //Dit zorgt er voor dat deze altijd met een komma komt.
            int id = 0;
            string name = "Micro USB";
            string description = "16 Gigabyte";
            decimal price = 2.57m;
            bool isPayed = false;
            bool isLeased = false;
            Material material = new Material(id, name, description, price, isPayed, isLeased);

            //Act
            string testString = material.ToString();
            Console.WriteLine(testString);

            //Assert
            Assert.IsTrue(testString == "Micro USB | 16 Gigabyte | 2,57");
        }
    }
}
