using Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for ExtensionsTest and is intended
    ///to contain all ExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExtensionsTest
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
        ///A test for IsPrime
        ///</summary>
        [TestMethod()]
        public void OneIsPrimeTest()
        {
            Assert.IsTrue(1.IsPrime());
        }

        [TestMethod()]
        public void TwoIsPrimeTest()
        {
            Assert.IsTrue(2.IsPrime());
        }

        /// <summary>
        ///A test for IsPositive
        ///</summary>
        [TestMethod()]
        public void IsPositiveTest()
        {
           Assert.IsTrue(345.IsPositive());
        }

        [TestMethod()]
        public void IsNotPositiveTest()
        {
            Assert.IsFalse((-95).IsPositive());
        }
    }
}
