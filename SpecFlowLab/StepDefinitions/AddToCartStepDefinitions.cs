using PagesLab2_Pages;
using TechTalk.SpecFlow;


namespace SpecFlowLab_2.StepDefinitions
{
    [Binding]
    public class StepDefinitions : BaseSteps
    {
        private LoginPage loginPage;
        private InventoryPage inventoryPage;
        private CartPage cartPage;
        private string productName;

        [Given(@"swaglabs page")]
        public void GivenSwaglabsPage()
        {
            driver.Url = "https://www.saucedemo.com";
            loginPage = new LoginPage(driver);
            inventoryPage = new InventoryPage(driver);
            cartPage = new CartPage(driver);
        }

        [When(@"user logined")]
        public void WhenUserLogined()
        {
            loginPage.LoginWithNameAndPassword();
        }

        [When(@"first product was added")]
        public void WhenFirstProductWasAdded()
        {
            productName = inventoryPage.AddFirstProductToCart();
        }

        [When(@"open cart page")]
        public void WhenOpenCartPage()
        {
            inventoryPage.OpenCartPage();
        }

        [Then(@"check if selected product was added")]
        public void ThenCheckIfSelectedProductWasAdded()
        {
            cartPage.CheckThatProductWasAdded(productName);
        }
    }
}