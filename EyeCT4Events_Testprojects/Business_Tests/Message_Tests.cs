using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Message_Tests
    {
        /// <summary>
        /// Basic setup for person.
        /// MAKING CHANGES TO THIS WILL MAKE CERTAIN TESTS FAIL!
        /// </summary>
        /// <returns>A person to use for testing.</returns>
        public Person MakePerson()
        {
            string name = "Batman";
            DateTime birthdate = new DateTime(1984, 3, 11);
            string address = "Wayne Manor";
            string phoneNumber = "077 - 888 412 12 14 3";
            string userName = "Not_Bruce_Wayne";
            string email = "Catwomanlover69@wayneenterprices.GC";
            string password = "I_am_Batman69";

            Person person = new Person(name, birthdate, address, phoneNumber, userName, email, password);

            return person;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Message_Exceptions_MessageStringMayNotBeNull()
        {
            //Arrange
            string messageString = null;
            int messageID = 1;
            int previousMessageID = 0;
            Person poster = MakePerson();

            //Act
            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Assert is Handled by the ExcpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Message_Exceptions_MessageStringMayNotBeSpaces()
        {
            //Arrange
            string messageString = "";
            int messageID = 1;
            int previousMessageID = 0;
            Person poster = MakePerson();

            //Act
            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Assert is Handled by the ExcpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Message_Exceptions_MessageIDMayNotBeLessThan1()
        {
            //Arrange
            string messageString = "This is a unit-test testmessage.";
            int messageID = 0;
            int previousMessageID = 0;
            Person poster = MakePerson();

            //Act
            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Assert is Handled by the ExcpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Message_Exceptions_PreviousMessageIDMayNotBeLessThan0()
        {
            //Arrange
            string messageString = "This is a unit-test testmessage.";
            int messageID = 1;
            int previousMessageID = -1;
            Person poster = MakePerson();

            //Act
            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Assert is Handled by the ExcpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Message_Exceptions_PosterMayNotBeNull()
        {
            //Arrange
            string messageString = "This is a unit-test testmessage.";
            int messageID = 1;
            int previousMessageID = 0;
            Person poster = null;

            //Act
            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Assert is Handled by the ExcpectedException.
        }

        [TestMethod]
        public void Message_Constructor_AllSettingsMinimum()
        {
            //Arrange
            string messageString = "This is a unit-test testmessage.";
            int messageID = 1;
            int previousMessageID = 0;
            Person poster = MakePerson();

            //Act
            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Assert
            Assert.IsTrue(message.MessageString == "This is a unit-test testmessage.");
            Assert.IsTrue(message.MessageID == 1);
            Assert.IsTrue(message.PreviousMessageID == 0);
            Assert.IsTrue(message.Poster.Name == "Batman");
        }

        [TestMethod]
        public void Message_ToString()
        {
            //Arrange
            string messageString = "This is a unit-test testmessage.";
            int messageID = 1;
            int previousMessageID = 0;
            Person poster = MakePerson();

            Message message = new Message(messageString, messageID, previousMessageID, poster);

            //Act
            string testString = message.ToString();

            //Assert
            Assert.IsTrue(testString == "Not_Bruce_Wayne | 1 | 0 | This is a unit-test testmessage.");
        }
    }
}
