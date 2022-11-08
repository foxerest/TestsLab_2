using OpenQA.Selenium;
using PagesLab2_Base;
using SeleniumExtras.PageObjects;

namespace PagesLab2_Pages
{
    public class LoginPage : PageBase
    {
        private const string LOGIN = "performance_glitch_user";
        private const string PASSWORD = "secret_sauce";

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement userNameElement { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement loginBtn { get; set; }

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void LoginWithNameAndPassword()
        {
            userNameElement.SendKeys(LOGIN);
            passwordElement.SendKeys(PASSWORD);
            loginBtn.Click();
        }
    }
}
