using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AnotherTestFramework
{
    [TestFixture]
    public class JustTest
    {
        IWebDriver driver;

        [SetUp]
        public void StartTest() // The method that will be fired at the start of the test
        {
            Browser.Init();
        }

        [TearDown]
        public void EndTest() // The method that will be fired at the end of the test
        {
            Browser.Close();
        }

        //[Test]
        //public void JustTest01() //This is where all action happens
        //{
        //    Assert.IsTrue(Page.support.isAt());
        //}
    }
}
