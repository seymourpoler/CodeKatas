using CodeKataDuplicatedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Lista_Test
{
    
    
    /// <summary>
    ///This is a test class for ListaTest and is intended
    ///to contain all ListaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListaTest
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
        ///A test for GetDuplicated
        ///</summary>
        [TestMethod()]
        public void GetDuplicated_Two_Numbers_Test()
        {
            List<int> valores = new List<int>(new int[] { 1, 1 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1 });
            List<int> actual = target.GetDuplicated();

            Assert.AreEqual(expected[0], actual[0]);
        }

        /// <summary>
        ///A test for GetDuplicated
        ///</summary>
        [TestMethod()]
        public void GetDuplicated_Three_Numbers_Test()
        {
            List<int> valores = new List<int>(new int[] { 1, 1, 2 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1 });
            List<int> actual = target.GetDuplicated();

            Assert.AreEqual(expected[0], actual[0]);
        }

        /// <summary>
        ///A test for GetDuplicated
        ///</summary>
        [TestMethod()]
        public void GetDuplicated_Four_Numbers_Test()
        {
            List<int> valores = new List<int>(new int[] { 1, 1, 2, 3 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1 });
            List<int> actual = target.GetDuplicated();

            Assert.AreEqual(expected[0], actual[0]);
        }

        /// <summary>
        ///A test for GetDuplicated
        ///</summary>
        [TestMethod()]
        public void GetDuplicated_Five_Numbers_Test()
        {
            List<int> valores = new List<int>(new int[] { 1, 1, 2, 3, 2 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1, 2 });
            List<int> actual = target.GetDuplicated();

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }


        /// <summary>
        ///A test for GetDuplicated
        ///</summary>
        [TestMethod()]
        public void GetDuplicatedTest()
        {
            List<int> valores = new List<int>(new int[] { 1, 1, 1, 2, 2 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1, 2 });
            List<int> actual = target.GetDuplicated();

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        /// <summary>
        ///A test for RemoveDuplicated
        ///</summary>
        [TestMethod()]
        public void RemoveDuplicated_Two_Numbers_Duplicated_Test()
        {
            List<int> valores = new List<int>(new int[] { 1, 1, 1, 2, 2 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1, 2 });
            List<int> actual;
            actual = target.RemoveDuplicated(valores);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        /// <summary>
        ///A test for RemoveDuplicated
        ///</summary>
        [TestMethod()]
        public void RemoveDuplicated_Three_Numbers_Duplicated_Test()
        {
            List<int> valores = new List<int>(new int[] { 1, 2, 1, 2, 5, 3, 3, 4 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 1, 2, 5, 3, 4 });
            List<int> actual;
            actual = target.RemoveDuplicated(valores);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
            Assert.AreEqual(expected[4], actual[4]);
        }

        /// <summary>
        ///A test for RemoveDuplicated
        ///</summary>
        [TestMethod()]
        public void RemoveDuplicated_Four_Numbers_Duplicated_Test()
        {
            List<int> valores = new List<int>(new int[] { 7, 1, 2, 1, 2, 5, 3, 3, 4, 7, 5, 8 });
            Lista target = new Lista(valores); // TODO: Initialize to an appropriate value
            List<int> expected = new List<int>(new int[] { 7, 1, 2, 5, 3, 4, 8 });
            List<int> actual;
            actual = target.RemoveDuplicated(valores);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
            Assert.AreEqual(expected[4], actual[4]);
            Assert.AreEqual(expected[5], actual[5]);
        }
    }
}
