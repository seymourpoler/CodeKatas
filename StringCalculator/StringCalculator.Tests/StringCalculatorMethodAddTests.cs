using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorMethodAddTests
    {
        [TestMethod]
        public void When_entry_is_empty_Should_Return_zero()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(string.Empty);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void When_entry_a_number_Should_Return_the_same_number()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("2");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void When_entry_two_numbers_Should_Return_the_sum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_Should_Return_the_sum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4,5");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_separated_throught_some_characters_Should_Return_the_sum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void When_entry_some_numbers_ended_in_a_character_Should_Return_the_sum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4,");
            Assert.AreEqual(10, result);
        }
    }
}
