using MaxMin;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManxMinTests
{
    [TestClass]
    public class MaxMinTests
    {
        private MaxMinManager _maxMin;

        [TestInitialize]
        public void SetUp()
        {
            _maxMin = new MaxMinManager();
        }

        [TestMethod]
        public void MaxMinManager_return_zero_when_input_in_max_is_empty()
        {
            var expected = 0;
            var data = new List<int>();

            var result = _maxMin.Max(data);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MaxMinManager_return_max_number_when_input_has_one_value()
        {
            var expected = 3;
            var data = new List<int>{3};

            var result = _maxMin.Max(data);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MaxMinManager_return_min_number_when_input_has_one_value()
        {
            var expected = 3;
            var data = new List<int> { 3 };

            var result = _maxMin.Max(data);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MaxMinManager_return_zero_when_input_in_min_is_empty()
        {
            var expected = 0;
            var data = new List<int>();

            var result = _maxMin.Min(data);

            Assert.AreEqual(expected, result);
        }
    }
}
