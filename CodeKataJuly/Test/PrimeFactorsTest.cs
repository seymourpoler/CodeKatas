using Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for PrimeFactorsTest and is intended
    ///to contain all PrimeFactorsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PrimeFactorsTest
    {
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
        ///A test for GeneratePrimeFactors
        ///</summary>
        [TestMethod()]
        public void SimpleNumberGeneratePrimeFactorsTest()
        {
            int number = 4; 
            PrimeFactors target = new PrimeFactors(number);
            
            List<int> expected = new List<int>();
            expected.Add(1); expected.Add(2); expected.Add(3);

            List<int> actual= target.GeneratePrimeFactors();
            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        [TestMethod()]
        public void TwoDigitsGeneratePrimeFactorsTest()
        {
            int number = 12;
            PrimeFactors target = new PrimeFactors(number);

            List<int> expected = new List<int>();
            expected.Add(1); expected.Add(2);
            expected.Add(3); expected.Add(5);
            expected.Add(7);expected.Add(11);

            List<int> actual = target.GeneratePrimeFactors();
            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        [TestMethod()]
        public void LittleGeneratePrimeFactorsTest()
        {
            int number = 15;
            PrimeFactors target = new PrimeFactors(number);

            List<int> expected = new List<int>();
            expected.Add(1); expected.Add(2);
            expected.Add(3); expected.Add(5);
            expected.Add(7); expected.Add(11);
            expected.Add(13);

            List<int> actual = target.GeneratePrimeFactors();
            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
    }
}
