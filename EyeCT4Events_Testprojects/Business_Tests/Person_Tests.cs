using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Person_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_NameMayNotBeSpaces()
        {
            //Arrange
            string name = "       ";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_NameMayNotBeNull()
        {
            //Arrange
            string name = null;
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Person_BirthDateMayNotBeLaterThanToday()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = DateTime.Now.AddDays(1);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Person_BirthDateMayNotBeToday()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = DateTime.Now;
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_AddressMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = null;
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_AddressMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_PhonenumberMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = null;
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_PhonenumberMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "                ";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_ZipCodeMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = null;
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_ZipCodeMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_accountNumbereMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = null;

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_AccountNumberMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "  ";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_EmailMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = null;
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_EmailMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "       ";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_EmailMayMustContainAtSymbol()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "bananaapplepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_EmailMayMustContainADotAfterTheAt_NoDot()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepennl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_EmailMayMustContainADotAfterTheAt_DotBeforeAt()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "ban.ana@applepennl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_PasswordMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = null;
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_PasswordMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "    ";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_CityMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = null;
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_CityMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = " ";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        public void Person_Constructor1_AllSettingsMinimum()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.Name == "Erik Molls");
            Assert.IsTrue(p1.BirthDate == new DateTime(1956, 12, 5));
            Assert.IsTrue(p1.Address == "Jongstraat 12");
            Assert.IsTrue(p1.Phonenumber == "0644543312");
            Assert.IsTrue(p1.ZipCode == "1111ZX");
            Assert.IsTrue(p1.Email == "banana@applepen.nl");
            Assert.IsTrue(p1.AccountNumber == "RABO 0 NL88 11223344");
            Assert.IsTrue(p1.Password == "Koekiemonster1");
            Assert.IsTrue(p1.City == "Bangkok");
        }

        [TestMethod]
        public void Person_Constructor2_AllSettingsMinimum()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            int admin = 1;

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, admin, accountNumber);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.Name == "Erik Molls");
            Assert.IsTrue(p1.BirthDate == new DateTime(1956, 12, 5));
            Assert.IsTrue(p1.Address == "Jongstraat 12");
            Assert.IsTrue(p1.Phonenumber == "0644543312");
            Assert.IsTrue(p1.ZipCode == "1111ZX");
            Assert.IsTrue(p1.Email == "banana@applepen.nl");
            Assert.IsTrue(p1.AccountNumber == "RABO 0 NL88 11223344");
            Assert.IsTrue(p1.Password == "Koekiemonster1");
            Assert.IsTrue(p1.City == "Bangkok");
        }

        [TestMethod]
        public void Person_Constructor3_AllSettingsMinimum()
        {
            //Arrange
            string name = "Erik Molls";
            string email = "banana@applepen.nl";
            string betaald = "betaald";

            //Act
            Person p1 = new Person(name, email, betaald);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.Name == "Erik Molls");
            Assert.IsTrue(p1.Email == "banana@applepen.nl");
            Assert.IsTrue(p1.Payed == "betaald");
        }

        [TestMethod]
        public void Person_Constructor4_AllSettingsMinimum()
        {
            //Arrange
            string name = "Erik Molls";
            string email = "banana@applepen.nl";

            //Act
            Person p1 = new Person(name, email);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.Name == "Erik Molls");
            Assert.IsTrue(p1.Email == "banana@applepen.nl");
        }

        [TestMethod]
        public void Person_Constructor5_AllSettingsMinimum()
        {
            //Arrange
            string email = "banana@applepen.nl";

            //Act
            Person p1 = new Person(email);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.Email == "banana@applepen.nl");
        }

        [TestMethod]
        public void Person_ToString()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";
            string zipcode = "1111ZX";
            string city = "Bangkok";
            string accountNumber = "RABO 0 NL88 11223344";

            //Act
            Person p1 = new Person(name, date, address, zipcode, city, phone, email, pasw, accountNumber);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.ToString() == "Erik Molls | " + date.ToString("d-M-yyyy") + " | Jongstraat 12 | 1111ZX | Bangkok | 0644543312 | banana@applepen.nl");
        }
    }
}
