using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.Common;

namespace OOP.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

           
            //Act
            var actual = source.InsertSpacess();

            //Assert
            Assert.AreEqual(expected, actual);
        }
   
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            
            //Act
            var actual = source.InsertSpacess();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

