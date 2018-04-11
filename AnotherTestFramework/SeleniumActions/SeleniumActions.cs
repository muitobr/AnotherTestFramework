using OpenQA.Selenium;
using System.Configuration;
using AnotherTestFramework.DriverOptions;
using AnotherTestFramework.ReportingStuff;

namespace AnotherTestFramework.SeleniumActions
{
    public class SeleniumActions : Browser
    {
        public enum locator
        {
            Id,
            Name,
            ClassName,
            XPath,
            CssSelector,
            LinkText,
            PartialLinkText,
            TagName
        }
        public By ElementLocator(locator locatorType, string value)
        {
            switch (locatorType)
            {
                case locator.Id:
                    return By.Id(value);
                case locator.Name:
                    return By.Name(value);
                case locator.ClassName:
                    return By.ClassName(value);
                case locator.XPath:
                    return By.XPath(value);
                case locator.CssSelector:
                    return By.CssSelector(value);
                case locator.LinkText:
                    return By.LinkText(value);
                case locator.PartialLinkText:
                    return By.PartialLinkText(value);
                case locator.TagName:
                    return By.TagName(value);
                default:
                    return null;
            }
        }



        public void CheckElement(locator locatorType, string value)
        {
            By locator;
            locator = ElementLocator(locatorType, value);
            IWebElement element = GetDriver.FindElement(locator);
            reports.verifyElementVisibility(element, locator);
        }


        public void InputTextOn(locator locatorType, string value, string text)
        {
            By locator;
            locator = ElementLocator(locatorType, value);
            IWebElement element = GetDriver.FindElement(locator);
            reports.verifyElementVisibility(element, locator);
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }


        public void ClickOn(locator locatorType, string value)
        { 
            By locator;
            locator = ElementLocator(locatorType, value);
            IWebElement element = GetDriver.FindElement(locator);
            reports.verifyElementVisibility(element, locator);
            element.Click();
        }


    }
}
