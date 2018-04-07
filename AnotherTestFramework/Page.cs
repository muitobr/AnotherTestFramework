using AnotherTestFramework.PageObject;
using OpenQA.Selenium.Support.PageObjects;
using AnotherTestFramework.DriverOptions;

namespace AnotherTestFramework
{
    public class Page
    {
        private static T getPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.GetDriver, page);
            return page;
        }

        //Home Page or Landing Page
        public static HomePage homePage
        {
            get { return getPages<HomePage>(); }
        }

        //Register Page
        public static Register register
        {
            get { return getPages<Register>(); }
        }

    }

}

