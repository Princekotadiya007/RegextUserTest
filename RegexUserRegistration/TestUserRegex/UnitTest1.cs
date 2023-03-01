using RegexUserRegistration;

namespace TestUserRegex
{
    public class Tests
    {
        RegexPrograms regex = new RegexPrograms();

        [Test]
        public void FirstName_ValidOrNot()
        {
            string result = regex.ValidateFirstName("Prince");
            Assert.AreEqual("Valid",result);
        }
        [Test]
        public void LasttName_ValidOrNot()
        {
            string result = regex.ValidateLastName("Kotadiya");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void Email_ValidOrNot()
        {
            string result = regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void PhoneNumber_ValidOrNot()
        {
            string result = regex.ValidatePhoneNumber("91 6352129268");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void PasswordRule1_ValidOrNot()
        {
            string result = regex.ValidPasswordRule1("Princes7");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void PasswordRule2_ValidOrNot()
        {
            string result = regex.ValidPasswordRule2("PRINCES7");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void PasswordRule3_ValidOrNot()
        {
            string result = regex.ValidPasswordRule3("Princes7");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void PasswordRule4_ValidOrNot()
        {
            string result = regex.ValidPasswordRule4("Prince07@");
            Assert.AreEqual("Valid", result);
        }
    }
}