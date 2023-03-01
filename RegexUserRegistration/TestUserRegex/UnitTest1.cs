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
            string result = regex.ValidateLastName("Prince");
            Assert.AreEqual("Valid", result);
        }
    }
}