using NUnit.Framework;
using OpenQA.Selenium;
using AnotherTestFramework.DriverOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTestFramework.ReportingStuff
{
    public class ReportManager
    {
        Report report;
        string browser;
        string url;
        
        IWebDriver driver = Browser.GetDriver;

        public ReportManager(string browser, string url)
        {
            this.browser = browser;
            this.url = url;
            report = new Report(browser, url);
        }

        public void VerifyURL(string url)
        {
            string PageURL = driver.Url;
            string message = "The Current Url and Expected Url are not equals";
            if (PageURL.Equals(url))
            {
                AddLog("Verify url", "PASS", "Url are Equals");
            }
            else
            {
                AddLog("Verify url", "FAIL", message);
            }
            Assert.AreEqual(PageURL, url, message);
        }

        public void VerifyElementVisibility(IWebElement element)
        {
            if (!element.Displayed)
            {
                string message = "Element does not exist";
                Assert.Fail(message);
                AddLog($"Looking For Element {element}", "FAIL", $"{element} Should Be On The Page");
            }
        }

        public void AddLog(string des, string res, string exp)
        {
            report.AddLine(des, res, exp);
        }
    }
}
