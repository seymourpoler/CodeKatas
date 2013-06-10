using CodeKataFizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeKataFizzBuzz_Test
{
    
    
    /// <summary>
    ///This is a test class for NumberTest and is intended
    ///to contain all NumberTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumberTest
    {
        private readonly string FIZZ = "Fizz";
        private readonly string BUZZ = "Buzz";
        private readonly string FIZZBUZZ = "FizzBuzz";

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for PrintFizzBuzz
        ///</summary>
        [TestMethod()]
        public void NegativeNumber_PrintFizzBuzzTest()
        {
            int number = -1;
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            List<string> actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected.Count, actual.Count);
        }


        /// <summary>
        ///A test for PrintFizzBuzz
        ///</summary>
        [TestMethod()]
        public void ZeroNumber_PrintFizzBuzzTest()
        {
            int number = 0; 
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            expected.Add(FIZZBUZZ);
            List<string> actual;
            actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected[0], actual[0]);
       }

        [TestMethod()]
        public void TwoNumbers_PrintFizzBuzzTest()
        {
            int number = 1;
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            expected.Add(FIZZBUZZ);
            expected.Add("1");
            List<string> actual;
            actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected[0], actual[0]);
        }

        [TestMethod()]
        public void ThreeNumbers_PrintFizzBuzzTest()
        {
            int number = 2;
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            expected.Add(FIZZBUZZ);
            expected.Add("1");
            expected.Add("2");
            List<string> actual;
            actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        [TestMethod()]
        public void FizzNumber_PrintFizzBuzzTest()
        {
            int number = 4;
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            expected.Add(FIZZBUZZ);
            expected.Add("1");
            expected.Add("2");
            expected.Add(FIZZ);
            List<string> actual;
            actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
        }

        [TestMethod()]
        public void FizzAndBuzzNumber_PrintFizzBuzzTest()
        {
            int number = 6;
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            expected.Add(FIZZBUZZ);
            expected.Add("1");
            expected.Add("2");
            expected.Add(FIZZ);
            expected.Add("4");
            expected.Add(BUZZ);
            List<string> actual;
            actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[4], actual[4]);
            Assert.AreEqual(expected[5], actual[5]);
        }

        [TestMethod()]
        public void FizzBuzzNumber_PrintFizzBuzzTest()
        {
            int number = 16;
            Number target = new Number(number); // TODO: Initialize to an appropriate value
            List<string> expected = new List<string>();
            expected.Add(FIZZBUZZ);expected.Add("1");expected.Add("2");
            expected.Add(FIZZ);expected.Add("4");
            expected.Add(BUZZ);expected.Add(FIZZ);expected.Add("7");
            expected.Add("8"); expected.Add(FIZZ); expected.Add(BUZZ);
            expected.Add("11"); expected.Add(FIZZ); expected.Add("13");
            expected.Add("14"); expected.Add(FIZZBUZZ);

            List<string> actual;
            actual = target.PrintFizzBuzz();
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[4], actual[4]);
            Assert.AreEqual(expected[5], actual[5]);
            Assert.AreEqual(expected[14], actual[14]);
        } 
    }
}
