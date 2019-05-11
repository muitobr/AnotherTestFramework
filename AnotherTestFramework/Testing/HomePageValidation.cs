using AnotherTestFramework.PageObject;
using NUnit.Framework;


namespace AnotherTestFramework.TestWillBeTest
{
    [TestFixture]
    public class HomePageValidation : TestBase
    {
        [Test]
        public void ValidateSignIn()
        {
            Page.homePage.LogoImageVisible();
            Page.homePage.InputEmailAdress("teste01@e-mail.com");
            Page.homePage.ClickSignIn();
        }

        [Test]
        public void ValidateEnterImage()
        {
            Page.homePage.LogoImageVisible();
            Page.homePage.InputEmailAdress("teste02@e-mail.com");
            Page.homePage.ClickEnterImage();
        }

        [Test]
        public void ValidateSkipSignIn()
        {
            Page.homePage.LogoImageVisible();
            Page.homePage.ClickSkipSignIn();
        }
    }
}
