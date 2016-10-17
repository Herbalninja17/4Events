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
        public void CreatePerson()
        {
            Person p1 = new Person("Erik Mols", new DateTime(1956, 12, 5), "Jongstraat 12", "0644543312", "Molsie12", "asdf", "Koekiemonster1");
        }
    }
}
