using System;
using AnotherTestFramework.SeleniumActions;

namespace AnotherTestFramework.PageObject
{
    public class HomePage
    {
        public static void ClickSkipSignIn()
        {
            Actions.Selenium.ClickOn("Id", "btn2");
        }
    }
}
