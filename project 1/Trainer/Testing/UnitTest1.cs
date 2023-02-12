using BusinessLogic;
using Core_EF;
using Model;
using Service;
namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("mahathi.@gmail.com")]
        [TestCase("mahathi123@gmailcom")]
        [TestCase("mounika@gmail.com")]
        [TestCase("Mahathi.12@gmail.com")]
        [TestCase("chinnu@gmail.com")]
        public void TestEmailId(string EmailId)
        {
            Assert.AreEqual(Validations.ValidEmailId(EmailId), EmailId);
        }
        [Test]
        [TestCase("mah123")]
        [TestCase("Mah123@")]
        [TestCase("Mah@123")]
        [TestCase("mie@123")]
        public void TestPassword(string Password)
        {
            Assert.AreEqual(Validations.ValidPassword(Password), Password);
        }
        [Test]
        [TestCase("123")]
        [TestCase("9542425933")]
        [TestCase("96529839956")]
        public void TestPhoneNumber(string PhoneNumber)
        {
            Assert.AreEqual(Validations.ValidPhoneNumber(PhoneNumber), PhoneNumber);
        }
    }
}