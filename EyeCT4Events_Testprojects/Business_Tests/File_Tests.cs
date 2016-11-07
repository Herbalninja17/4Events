using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class File_Tests
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
            string city = "gotham";
            string zipcode = "1111ZX";
            string phoneNumber = "077 - 888 412 12 14 3";
            string email = "Catwomanlover69@wayneenterprices.GC";
            string password = "I_am_Batman69";
            string accountNumber = "RABO 0 184433221";

            Person person = new Person(name, birthdate, address, zipcode, city, phoneNumber, email, password, accountNumber);

            return person;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void File_TitleMayNotBeNull()
        {
            //Arrange
            string title = null;
            string fileName = "c://fakedir/fakefilename.jpeg";
            string fileType = "JPEG";
            int fileID = 1;
            Person poster = MakePerson();

            //Act
            File file = new File(title, fileName, fileType, fileID, poster);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void File_TitleMayNotBeSpaces()
        {
            //Arrange
            string title = "";
            string fileName = "c://fakedir/fakefilename.jpeg";
            string fileType = "JPEG";
            int fileID = 1;
            Person poster = MakePerson();

            //Act
            File file = new File(title, fileName, fileType, fileID, poster);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        public void File_Constructor_Receive()
        {
            //Arrange
            string title = "Awesome Video Mashup";
            string fileName = "c://fakedir/fakefilename.jpeg";
            string fileType = "JPEG";
            int fileID = 1;
            Person poster = MakePerson();

            //Act
            File file = new File(title, fileName, fileType, fileID, poster);

            //Assert
            Assert.IsTrue(file.Title == "Awesome Video Mashup");
            Assert.IsTrue(file.Poster.Name == "Batman");
        }

        [TestMethod]
        public void File_Constructor_Create()
        {
            //Arrange
            string title = "Awesome Video Mashup";
            string fileName = "c://fakedir/fakefilename.jpeg";
            Person poster = MakePerson();

            //Act
            File file = new File(title, fileName, poster);

            //Assert
            Assert.IsTrue(file.Title == "Awesome Video Mashup");
            Assert.IsTrue(file.Poster.Name == "Batman");
        }

        [TestMethod]
        public void File_CheckFileType()
        {
            //Arrange
            Person poster = MakePerson();

            string fileName1 = "c://fakedir/fakefilename.jpg";
            string fileName2 = "c://fakedir/fakerdir/fakefile.dumbuserdot.jpeg";
            string fileName3 = "c://fakedir/fakefilename...png";
            string fileName4 = "c://fakedir/fakefilename.jpg.png.jpeg.gif";
            string badFileName = "c://fakedir/fakefilename.jpg.png.jpeg.gif.badextension";

            File file1 = new File("Title", fileName1, poster);
            File file2 = new File("Title", fileName2, poster);
            File file3 = new File("Title", fileName3, poster);
            File file4 = new File("Title", fileName4, poster);
            File badFile = new File("Title", badFileName, poster);

            //Act
            string fN1 = file1.CheckFileType(file1.FileName);
            string fN2 = file2.CheckFileType(file1.FileName);
            string fN3 = file3.CheckFileType(file1.FileName);
            string fN4 = file4.CheckFileType(file1.FileName);
            string bFN = badFile.CheckFileType(file1.FileName);

            Console.WriteLine(fN1);

            //Assert
            Assert.IsTrue(fN1 == "jpg");
            Assert.IsTrue(fN2 == "jpeg");
            Assert.IsTrue(fN3 == "png");
            Assert.IsTrue(fN4 == "gif");
            Assert.IsTrue(bFN == "");
        }

        [TestMethod]
        public void File_ToString()
        {
            //Arrange
            string title = "Awesome Video Mashup";
            string fileName = "c://fakedir/fakefilename.jpeg";
            string fileType = "JPEG";
            int fileID = 1;
            Person poster = MakePerson();

            File file = new File(title, fileName, fileType, fileID, poster);

            //Act
            string testString = file.ToString();
            Console.WriteLine(testString);

            //Assert
            Assert.IsTrue(testString == "Awesome Video Mashup | JPEG | 1 | Catwomanlover69@wayneenterprices.GC");
        }
    }
}
