using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AnotherTestFramework
{
    public class Browser
    {
        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    GetDriver = new ChromeDriver();
                    break;
                case "IE":
                    GetDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    GetDriver = new FirefoxDriver();
                    break;
            }
            GetDriver.Manage().Window.Maximize();
            Goto(baseURL);
        }
        public static string Title
        {
            get { return GetDriver.Title; }
        }
        public static IWebDriver GetDriver { get; private set; }
        public static void Goto(string url)
        {
            GetDriver.Url = url;
        }
        public static void Close()
        {
            GetDriver.Quit();
        }
    }
}
