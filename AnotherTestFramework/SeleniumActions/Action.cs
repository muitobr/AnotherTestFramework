using OpenQA.Selenium.Support.PageObjects;
using System;
using AnotherTestFramework.DriverOptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTestFramework.SeleniumActions
{
    class Action
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.GetDriver, page);
            Browser.GetDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return page;
        }

        public static SeleniumActions Selenium
        {
            get { return GetPage<SeleniumActions>(); }
        }
    }
}
