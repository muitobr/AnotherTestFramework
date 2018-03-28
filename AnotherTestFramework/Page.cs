using AnotherTestFramework.PageObject;
using OpenQA.Selenium.Support.PageObjects;

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

        public static HomePage homePage
        {
            get { return getPages<HomePage>(); }
        }

        public static Support support
        {
            get { return getPages<Support>(); }
        }
    }

}
}
