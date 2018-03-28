using NUnit.Framework;
using OpenQA.Selenium;
using AnotherTestFramework;

namespace AnotherTestFramework.TestWillBeTest
{
    [TestFixture]
    public class Sanity : JustTest
    {
        [Test]
        public void ClickSupport()
        {
            Browser.GetDriver.FindElement(By.Id("menu_support")).Click();
        }
    }
}
