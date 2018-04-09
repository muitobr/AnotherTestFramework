using System;
using AnotherTestFramework.SeleniumActions;

namespace AnotherTestFramework.PageObject
{
    public class HomePage
    {
        public void ClickSkipSignIn()
        {
            Actions.Selenium.ClickOn("Id", "btn2");
        }
    }
}
