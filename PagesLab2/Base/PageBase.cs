using OpenQA.Selenium;

namespace PagesLab2_Base
{
    public class PageBase
    {
        protected static IWebDriver driver;

        public PageBase(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
