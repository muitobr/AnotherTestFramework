using NUnit.Framework;
using AnotherTestFramework.DriverOptions;

namespace AnotherTestFramework
{
    [TestFixture]
    public class TestBase
    {
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

    }
}
