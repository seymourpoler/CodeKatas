using CodeKataNovember;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeKataNovember_Test
{
    
    /// <summary>
    ///This is a test class for BooksTest and is intended
    ///to contain all BooksTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BooksTest
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
        ///A test for GetPrice
        ///</summary>
        [TestMethod()]
        public void GetPrice_One_Book()
        {
            Books target = new Books(new List<int>(new int[] { 0 })); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(8);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Two_diffent_Books()
        {
            Books target = new Books(new List<int>(new int[] { 0, 0})); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(15.2);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Three_diffent_Books()
        {
            Books target = new Books(new List<int>(new int[] { 0, 0, 0 })); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(21.6);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Three_diffent_One_Equal_Books()
        {
            Books target = new Books(new List<int>(new int[] { 0, 0, 1 })); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(29.6);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Four_diffent_One_Equal_Books()
        {
            Books target = new Books(new List<int>(new int[] { 0, 0, 1, 0 })); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(33.6);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Four_diffent_Three_Equal_Books()
        {
            Books target = new Books(new List<int>(new int[] { 0, 1, 1, 1 })); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(47.2);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Five_diffent_Three_Equal_Books()
        {
            Books target = new Books(new List<int>(new int[] { 0, 0, 1, 1, 1 })); // TODO: Initialize to an appropriate value
            decimal expected = Convert.ToDecimal(51.20);
            decimal actual = target.GetPrice();
            Assert.AreEqual(expected, actual);
        }
    }
}
