using SMS;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTests
{
    [TestClass]
    public class SMSManagerTests
    {
        private SMSManager _smsManager;
        private ICharacterManager _characterManager;

        [TestInitialize]
        public void SetUp()
        {
            _characterManager = new CharacterManager();
            _smsManager = new SMSManager(_characterManager);
        }

        [TestMethod]
        public void SMSManager_GetCharacter_with_the_same_number()
        {
            var sms = "6 666 66 666";
            var expected = "mono";

            var result = _smsManager.WriteMessage(sms);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SMSManager_GetCharacter_with_different_numbers()
        {
            var sms = "222 277772";
            var expected = "casa";

            var result = _smsManager.WriteMessage(sms);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SMSManager_GetNumbers_return_list_string_empty_when_is_string_empty()
        {
            var sms = string.Empty;
            var expected = new List<string> { };

            var result = _smsManager.GetNumbers(sms);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void SMSManager_GetNumbers_return_the_number()
        {
            var sms = "2";
            var expected = new List<string> { "2" };

            var result = _smsManager.GetNumbers(sms);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void SMSManager_GetNumbers_return_different_numbers()
        {
            var sms = "24";
            var expected = new List<string> { "2", "4" };

            var result = _smsManager.GetNumbers(sms);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void SMSManager_GetNumbers_return_the_same_numbers()
        {
            var sms = "224";
            var expected = new List<string> { "22", "4" };

            var result = _smsManager.GetNumbers(sms);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void SMSManager_GetNumbers()
        {
            var sms = "277772";
            var expected = new List<string> { "2", "7777", "2" };

            var result = _smsManager.GetNumbers(sms);

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
