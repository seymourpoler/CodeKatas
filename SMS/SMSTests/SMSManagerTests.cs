using SMS;
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
        public void SMSManager_GetCharacter()
        {
            var sms = "6 666 66 666";
            var expected = "mono";

            var result = _smsManager.WriteMessage(sms);

            Assert.AreEqual(expected, result);
        }
    }
}
