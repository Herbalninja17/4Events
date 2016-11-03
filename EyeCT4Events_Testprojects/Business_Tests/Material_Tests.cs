//using System;
//using System.Globalization;
//using System.Threading;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EyeCT4Events;

//namespace EyeCT4Events_Testprojects.Business_Tests
//{
//    [TestClass]
//    public class Material_Tests
//    {
//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void Material_Exceptions_NameCannotBeNull()
//        {
//            //Arrange
//            string name = null;
//            MaterialType materialType = MaterialType.Camera;
//            int stock = 10;
//            decimal price = 2.75m;
//            bool isPayed = false;

//            //Act
//            Material material = new Material(name, materialType, stock, price, isPayed);

//            //Assert is Handled by the ExpectedException.
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Material_Exceptions_NameMayNotBeSpaces()
//        {
//            //Arrange
//            string name = "           ";
//            MaterialType materialType = MaterialType.Camera;
//            int stock = 10;
//            decimal price = 2.75m;
//            bool isPayed = false;

//            //Act
//            Material material = new Material(name, materialType, stock, price, isPayed);

//            //Assert is Handled by the ExpectedException.
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void Material_Exceptions_StockMayNotBeLessThan0()
//        {
//            //Arrange
//            string name = "SpyCam";
//            MaterialType materialType = MaterialType.Camera;
//            int stock = -1;
//            decimal price = 2.75m;
//            bool isPayed = false;

//            //Act
//            Material material = new Material(name, materialType, stock, price, isPayed);

//            //Assert is Handled by the ExpectedException.
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void Material_Exceptions_PriceMayNotBeLessThan0()
//        {
//            //Arrange
//            string name = "SpyCam";
//            MaterialType materialType = MaterialType.Camera;
//            int stock = 10;
//            decimal price = -1;
//            bool isPayed = false;

//            //Act
//            Material material = new Material(name, materialType, stock, price, isPayed);

//            //Assert is Handled by the ExpectedException.
//        }

//        [TestMethod]
//        public void Material_Constructor_AllSettingsMinimum()
//        {
//            //Arrange
//            string name = "SpyCam";
//            MaterialType materialType = MaterialType.Camera;
//            int stock = 0;
//            decimal price = 0.01m;
//            bool isPayed = false;

//            //Act
//            Material material = new Material(name, materialType, stock, price, isPayed);

//            //Assert
//            Assert.IsTrue(material.Stock == 0);
//            Assert.IsTrue(material.Price == 0.01m);
//            Assert.IsTrue(material.Name == "SpyCam");
//            Assert.IsTrue(material.MaterialType == MaterialType.Camera);
//            Assert.IsFalse(material.IsPayed);
//        }

//        [TestMethod]
//        public void Material_ToString()
//        {
//            //Arrange
//            Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL"); //In sommige systemen komt de prijs met een punt i.p.v een komma
//                                                                            //Dit zorgt er voor dat deze altijd met een komma komt.
//            string name = "Micro-USB";
//            MaterialType materialType = MaterialType.USB;
//            int stock = 10;
//            decimal price = 2.75m;
//            bool isPayed = true;
//            Material material = new Material(name, materialType, stock, price, isPayed);

//            //Act
//            string testString = material.ToString();
//            string materialTypeString = materialType.ToString();

//            //Assert
//            Assert.IsTrue(testString == "Micro-USB | " + materialTypeString + " | 10 | 2,75 | Is betaald.");
//        }
//    }
//}
