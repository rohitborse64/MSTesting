using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSUnitTests.Model;
using System;

namespace MSUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange  
            Employee objEmployee = new Employee();
            String firstName = "Narasimha";
            String lastName = "Reddy";
            String expected = "Narasimha Reddy";
            String actual;
            //Act  
            actual = objEmployee.GetName(firstName, lastName);
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}
