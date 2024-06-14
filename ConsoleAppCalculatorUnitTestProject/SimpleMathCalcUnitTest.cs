using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleAppCalculator;

namespace ConsoleAppCalculatorUnitTestProject
{
    [TestClass]
    public class SimpleMathCalcUnitTest
    {
        [TestMethod]
        public void GetSum_3plus5_Return8()
        {
            //Arrange
            SimpleMathCalc simpleMathCalc = new SimpleMathCalc(3, 5);

            //Act
            double expected = 8;
            double actual = simpleMathCalc.GetSum();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSub_10minus5_Return5()
        {
            //Arrange
            SimpleMathCalc simpleMathCalc = new SimpleMathCalc(10, 5);

            //Act
            double expected = 5;
            double actual = simpleMathCalc.GetSub();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetDev_2devide0_ThrowException()
        {
            //Arrange
            SimpleMathCalc simpleMathCalc = new SimpleMathCalc(10, 0);

            //Act
            double actual = simpleMathCalc.GetDev();
        }

        [TestMethod]
        public void GetDev_4devide2_Return2()
        {
            //Arrange
            SimpleMathCalc simpleMathCalc = new SimpleMathCalc(4, 2);

            //Act
            double expected = 2;
            double actual = simpleMathCalc.GetDev();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDev_4devide1_Return4()
        {
            //Arrange
            SimpleMathCalc simpleMathCalc = new SimpleMathCalc(4, 0);

            //Act
            double expected = 4;
            double actual = simpleMathCalc.GetDev();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
