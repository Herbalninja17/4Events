using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    [TestClass]
    public class Maintain_Tests
    {
        public void BasicSetup(Maintain maintain)
        {
             
        }

        [TestMethod]
        public void Maintain_AddPerson_PersonIsAdded()
        {
            //Arrange
            Maintain Maintain = new Maintain();
            Person testPerson = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");

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
            Person testPerson = new Person("Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");
            Person testPerson2 = new Person("Not Bruce Banner", new DateTime(1973, 1, 6), "Wayne Manor", "1111ZX", "0555-882244", "Darkknight@batcave.we", "Wonderwoman69", "RABO 0 NL88 11223344");

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
    }
}
