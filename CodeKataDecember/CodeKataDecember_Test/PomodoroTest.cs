using CodeKataDecember;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeKataDecember_Test
{
    
    
    /// <summary>
    ///This is a test class for PomodoroTest and is intended
    ///to contain all PomodoroTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PomodoroTest
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
        ///A test for Stop
        ///</summary>
        [TestMethod()]
        //[ExpectedException(typeof(Exception))]
        public void Stop_WithOutStart()
        {
            Pomodoro target = null;
            try
            {
                target = new Pomodoro(); // TODO: Initialize to an appropriate value
                target.Stop();
                Assert.Fail("Exception is not thrown.");
            }
            catch (Exception exp) { Assert.IsTrue(0 != target.Minutes); }
        }

        /// <summary>
        ///A test for Constructor
        ///</summary>
        [TestMethod()]
        public void Constructor_WithOutMinutes()
        {
            Pomodoro target = new Pomodoro(); // TODO: Initialize to an appropriate value
            Assert.AreEqual(25 * 60, target.Minutes);
        }

        /// <summary>
        ///A test for constructor
        ///</summary>
        [TestMethod()]
        public void Constructor_WithMinutes()
        {
            Pomodoro target = new Pomodoro(1254); // TODO: Initialize to an appropriate value
            Assert.AreEqual(1254 * 60, target.Minutes);
        }

        /// <summary>
        ///A test for count the interruptions
        ///</summary>
        [TestMethod()]
        public void Count_theInterruptiions()
        {
            Pomodoro target = new Pomodoro(1254); // TODO: Initialize to an appropriate value
            target.Start();
            target.Pause();
            target.Start();
            Assert.AreEqual(1, target.Interruptions);
        }
    }
}
