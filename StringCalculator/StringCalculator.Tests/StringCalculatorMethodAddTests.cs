using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorMethodAddTests
    {
        private StringCalculator _calculator;
        
        public StringCalculatorMethodAddTests()
        {
            _calculator = new StringCalculator();
        }

        [TestMethod]
        public void When_entry_is_empty_Should_Return_zero()
        {
            var result = _calculator.Add(string.Empty);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void When_entry_a_number_Should_Return_the_same_number()
        {
            var result = _calculator.Add("2");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void When_entry_two_numbers_Should_Return_the_sum()
        {
            var result = _calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_Should_Return_the_sum()
        {
            var result = _calculator.Add("1,2,3,4,5");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_separated_throught_some_characters_Should_Return_the_sum()
        {
            var result = _calculator.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_ended_in_a_character_Should_Return_the_sum()
        {
            var result = _calculator.Add("1,2,3,4,");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_with_different_delimiters_Should_Return_the_sum()
        {
            var result = _calculator.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void When_entry_some_number_is_negative_Should_Return_an_exception()
        {
            _calculator.Add("1,2,-3");
            Assert.Fail("Exception expected");
        }

        [TestMethod]
        public void When_some_number_is_bigger_than_1000_Should_be_ignored()
        {
            var result = _calculator.Add("2 + 1001");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_with_different_length_delimiters_Should_Return_the_sum()
        {
            var result = _calculator.Add("//****\n1****2****3");
            Assert.AreEqual(6, result);
        }
    }
}
