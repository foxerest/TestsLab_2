using NUnit.Framework;
using OpenQA.Selenium;
using PagesLab2_Base;
using SeleniumExtras.PageObjects;

namespace PagesLab2_Pages
{
    public class CartPage : PageBase
    {
        private const string CART_TITLE = "YOUR CART";

        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement cartTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_contents_container']/div/div[1]")]
        private IWebElement cartList { get; set; }


        public CartPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void CheckThatCartIsOpened()
        {
            var titleText = cartTitle.Text;
            Assert.That(titleText.ToLower().Contains(CART_TITLE.ToLower()));
        }

        public void CheckThatProductWasAdded(string name)
        {
            Assert.That(cartList.FindElement(By.LinkText(name)), Is.Not.Null);
        }
    }
}
