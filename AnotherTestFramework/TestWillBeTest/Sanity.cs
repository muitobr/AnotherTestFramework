using NUnit.Framework;
using AnotherTestFramework.SeleniumActions;

namespace AnotherTestFramework.TestWillBeTest
{
    [TestFixture]
    public class Sanity : TestBase
    {
        [Test]
        public void ClickSkipSignIn()
        {
            Action.Selenium.ClickOn("Id", "btn2");
        }
    }
}
