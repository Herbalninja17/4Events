﻿using System;
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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Person_UsernameMayNotBeNull()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string usename = null;
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_UsernameMayNotBeSpaces()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string usename = "";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = null;
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "       ";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "bananaapplepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepennl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "ban.ana@applepennl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = null;

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

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
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "    ";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        public void Person_Constructor_AllSettingsMinimum()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.Name == "Erik Molls");
            Assert.IsTrue(p1.BirthDate == new DateTime(1956, 12, 5));
            Assert.IsTrue(p1.Address == "Jongstraat 12");
            Assert.IsTrue(p1.Phonenumber == "0644543312");
            Assert.IsTrue(p1.Username == "Molsie12");
            Assert.IsTrue(p1.Email == "banana@applepen.nl");
            Assert.IsTrue(p1.Password == "Koekiemonster1");
        }

        [TestMethod]
        public void Person_Constructor2_AllSettingsMinimum()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

            //Act
            Person p2 = new Person(p1.Username, p1.Password);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p2.Username == "Molsie12");
            Assert.IsTrue(p2.Password == "Koekiemonster1");
        }

        [TestMethod]
        public void Person_ToString()
        {
            //Arrange
            string name = "Erik Molls";
            DateTime date = new DateTime(1956, 12, 5);
            string address = "Jongstraat 12";
            string phone = "0644543312";
            string usename = "Molsie12";
            string email = "banana@applepen.nl";
            string pasw = "Koekiemonster1";

            //Act
            Person p1 = new Person(name, date, address, phone, usename, email, pasw);

            //Assert is handled by the ExpectedException
            Assert.IsTrue(p1.ToString() == "Erik Molls | " + date + " | Jongstraat 12 | 0644543312 | Molsie12 | banana@applepen.nl | Koekiemonster1");
        }
    }
}