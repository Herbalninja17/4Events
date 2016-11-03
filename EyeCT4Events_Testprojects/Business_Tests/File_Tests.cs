//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EyeCT4Events;

//namespace EyeCT4Events_Testprojects.Business_Tests
//{
//    [TestClass]
//    public class File_Tests
//    {
//        /// <summary>
//        /// Basic setup for person.
//        /// MAKING CHANGES TO THIS WILL MAKE CERTAIN TESTS FAIL!
//        /// </summary>
//        /// <returns>A person to use for testing.</returns>
//        public Person MakePerson()
//        {
//            string name = "Batman";
//            DateTime birthdate = new DateTime(1984, 3, 11);
//            string address = "Wayne Manor";
//            string zipcode = "1111ZX";
//            string phoneNumber = "077 - 888 412 12 14 3";
//            string email = "Catwomanlover69@wayneenterprices.GC";
//            string password = "I_am_Batman69";
//            string accountNumber = "RABO 0 184433221";

//            Person person = new Person(name, birthdate, address, zipcode, phoneNumber, email, password, accountNumber);

//            return person;
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void File_TitleMayNotBeNull()
//        {
//            //Arrange
//            string title = null;
//            FileType filetype = FileType.Video;
//            int fileID = 1;
//            Person poster = MakePerson();

//            //Act
//            File file = new File(title, filetype, fileID, poster);

//            //Assert is handled by the ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void File_TitleMayNotBeSpaces()
//        {
//            //Arrange
//            string title = "";
//            FileType filetype = FileType.Video;
//            int fileID = 1;
//            Person poster = MakePerson();

//            //Act
//            File file = new File(title, filetype, fileID, poster);

//            //Assert is handled by the ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void File_FileIDMayNotBeLessThanOne()
//        {
//            //Arrange
//            string title = "Awesome Video Mashup";
//            FileType filetype = FileType.Video;
//            int fileID = 0;
//            Person poster = MakePerson();

//            //Act
//            File file = new File(title, filetype, fileID, poster);

//            //Assert is handled by the ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void File_FileIDMayNotBeANegativeNumber()
//        {
//            //Arrange
//            string title = "Awesome Video Mashup";
//            FileType filetype = FileType.Video;
//            int fileID = -642;
//            Person poster = MakePerson();

//            //Act
//            File file = new File(title, filetype, fileID, poster);

//            //Assert is handled by the ExpectedException
//        }

//        [TestMethod]
//        public void File_Constructor()
//        {
//            //Arrange
//            string title = "Awesome Video Mashup";
//            FileType filetype = FileType.Video;
//            int fileID = 8;
//            Person poster = MakePerson();

//            //Act
//            File file = new File(title, filetype, fileID, poster);

//            //Assert
//            Assert.IsTrue(file.Title == "Awesome Video Mashup");
//            Assert.IsTrue(file.Poster.Name == "Batman");
//        }

//        [TestMethod]
//        public void File_ToString()
//        {
//            //Arrange
//            string title = "Awesome Video Mashup";
//            FileType filetype = FileType.Video;
//            int fileID = 8;
//            Person poster = MakePerson();
//            File file = new File(title, filetype, fileID, poster);

//            //Act
//            string testString = file.ToString();

//            //Assert
//            Assert.IsTrue(testString == "Awesome Video Mashup | Video | 8 | Catwomanlover69@wayneenterprices.GC");
//        }
//    }
//}
