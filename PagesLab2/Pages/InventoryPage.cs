using NUnit.Framework;
using OpenQA.Selenium;
using PagesLab2_Base;
using SeleniumExtras.PageObjects;

namespace PagesLab2_Pages
{
    public class InventoryPage : PageBase
    {
        private const string INVENTORY_TITLE = "PRODUCTS";

        [FindsBy(How = How.XPath, Using = "//*[@id='header_container']/div[2]/span")]
        private IWebElement inventoryTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='inventory_container']/div/div[1]/div[2]/div[1]/a/div")]
        private IWebElement firstProductName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='inventory_container']/div/div[1]/div[2]/div[2]/button")]
        private IWebElement firstProductBtn { get; set; }

        [FindsBy(How = How.Id, Using = "shopping_cart_container")]
        private IWebElement cartBtn { get; set; }

        public InventoryPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void CheckThatUserIsLogedIn()
        {
            var titleText = inventoryTitle.Text;
            Assert.That(titleText.ToLower().Contains(INVENTORY_TITLE.ToLower()));
        }

        public string AddFirstProductToCart()
        {
            firstProductBtn.Click();
            return firstProductName.Text;
        }

        public void OpenCartPage()
        {
            cartBtn.Click();
        }

    }
}
