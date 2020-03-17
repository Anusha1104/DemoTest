using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass()]
    public class BLClassTest
    {
        [TestMethod()]
        public void AgeTest1()
        {
            BLClass b = new BLClass();
            string str = "04/11/1998";
            
            int age = 0;
            int expected=21;
            age = b.Age(str);
            Assert.AreEqual(expected, age);
        }

        [TestMethod()]
        public void AgeTest2()
        {
            BLClass b = new BLClass();
            string str = "04/11/2005";

            int age = 0;
            var expected = Assert.ThrowsException<CustomException>(()=>b.Age(str));
          
            Assert.AreEqual("Age should be less than 18 or greater than 60", expected.Message);
        }
    }
}

namespace Test
{
    [TestClass]
    public class BLClassTest
    {
        [TestMethod]
        public void DivideTest1()
        {
            //Arrange - Declare Actuals and Expected
            int numerator = 10;
            int denominator = 2;
            int actual=0;
            int expected = 5;

            //Act - call the method and pass the actuals as parameters
            BLClass B = new BLClass();
            actual = B.Divide(numerator.ToString(), denominator.ToString());

            // Assert - check whether Actuals are matching with expected
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTest2()
        {
            //Arrange - Declare Actuals and Expected
            int numerator = 0;
            int denominator =2;
            int actual = 0;
            int expected = 0;

            //Act - call the method and pass the actuals as parameters
            BLClass B = new BLClass();
            actual = B.Divide(numerator.ToString(), denominator.ToString());

            // Assert - check whether Actuals are matching with expected
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTest3()
        {
            //Arrange - Declare Actuals and Expected
            int numerator = 10;
            int denominator = 0;
            BLClass B = new BLClass();
            var expected = Assert.ThrowsException<DivideByZeroException>(() => B.Divide(numerator.ToString(), denominator.ToString()));
            Assert.AreEqual("Cannot divide by zero",expected.Message);
         
        }

        [TestMethod]
        public void DivideTest4()
        {
            BLClass B = new BLClass();
            var ex = Assert.ThrowsException<FormatException>(() => B.Divide("abc","xyz"));
            Assert.AreEqual("only numbers", ex.Message);
        }
}
}
