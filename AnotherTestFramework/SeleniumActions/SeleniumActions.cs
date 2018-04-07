using OpenQA.Selenium;
using AnotherTestFramework.DriverOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTestFramework.SeleniumActions
{
    class SeleniumActions
    {

        public By ElementLocator(string locatorType, string value)
        {
            switch (locatorType)
            {
                case "Id":
                    return By.Id(value);
                case "Name":
                    return By.Name(value);
                case "ClassName":
                    return By.ClassName(value);
                case "XPath":
                    return By.XPath(value);
                case "CssSelector":
                    return By.CssSelector(value);
                case "LinkText":
                    return By.LinkText(value);
                case "PartialLinkText":
                    return By.PartialLinkText(value);
                case "TagName":
                    return By.TagName(value);
                default:
                    return null;
            }
        }


        public void ClickOn(string locatorType, string value)
        {
            By locator;
            locator = ElementLocator(locatorType, value);
            IWebElement element = Browser.GetDriver.FindElement(locator);

            if (element.Displayed)
            {
                element.Click();
            }
        }
    }
}
