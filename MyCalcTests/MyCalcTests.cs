using Calculator;
using NUnit.Framework;
using System;

namespace MyCalcTests
{
    [TestFixture()]
    public class MyCalcTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Sum_2and2_4returned()
        {
            int a = 2,
                b = 2,
                expected = 4,
                actual;

            Calculator1 calc = new();
            actual = calc.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Subtraction_2and2_0returned()
        {
            int a = 2,
                b = 2,
                expected = 4,
                actual;

            Calculator1 calc = new();
            actual = calc.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multi_2and2_4returned()
        {
            int a = 2,
                b = 2,
                expected = 4,
                actual;

            Calculator1 calc = new();
            actual = calc.Multi(a, b);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Divide_4and2_2returned()
        {
            int a = 4,
                b = 2,
                expected=2,
                actual;

            Calculator1 calc = new();
            actual = calc.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SumString_2and2_4returned()
        {
            string str = "2+2";
            int expected = 4;
            object actual = StringMathCalculator.Sum(str);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void StrConcat_2and22returned()
        {
            string str = "2";
            string str1 = "2";
            string expected = "22";
            object actual = StringLingvoCalculator.Sum(str,str1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Ignore("Ignore a test")]
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }


    }
}