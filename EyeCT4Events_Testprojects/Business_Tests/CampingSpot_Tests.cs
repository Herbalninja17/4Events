using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Events;

namespace EyeCT4Events_Testprojects.Business_Tests
{
    /// <summary>
    /// All data for this class comes from the database.
    /// Exceptions for variables will be caught in the datalayer
    /// for this class.
    /// </summary>
    [TestClass]
    public class CampingSpot_Tests
    {
        [TestMethod]
        public void CampingSpot_ToString()
        {
            //Arrange
            CampingSpot spot1 = new CampingSpot(SpotType.Eigen_tent, 1, 101, 5, true, 28);
            CampingSpot spot2 = new CampingSpot(SpotType.Bungalino, 43, 336, 4, false, 28);

            //No Actions needed for this test.

            //Assert
            Assert.IsTrue(spot1.ToString() == "1 | Eigen_tent | 5 | reserved");
            Assert.IsTrue(spot2.ToString() == "43 | Bungalino | 4 | open");
        }

    }
}
