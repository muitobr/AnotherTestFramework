using AnotherTestFramework.PageObject;
using NUnit.Framework;


namespace AnotherTestFramework.TestWillBeTest
{
    [TestFixture]
    public class TestCase001 : TestBase
    {
        [Test]
        public void HomePageValidation()
        {
            Page.homePage.LogoImageVisible();
            Page.homePage.InputEmailAdress("teste@e-mail.com");
            Page.homePage.ClickSkipSignIn();
        }
    }
}
