using AnotherTestFramework.PageObject;
using NUnit.Framework;


namespace AnotherTestFramework.TestWillBeTest
{
    [TestFixture]
    public class Sanity : TestBase
    {
        [Test]
        public void SanityTest()
        {
            HomePage.ClickSkipSignIn();
        }
    }
}
