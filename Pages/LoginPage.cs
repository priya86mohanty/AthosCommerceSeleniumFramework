namespace AthosCommerceSeleniumFramework.Pages;

public class LoginPage
{
    private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;

    private readonly By _usernameInput = By.Id("username");
    private readonly By _passwordInput = By.Id("password");
    private readonly By _loginButton = By.CssSelector("button[type='submit']");

    public LoginPage(IWebDriver driver, WebDriverWait wait)
    {
        _driver = driver;
        _wait = wait;
    }

    public void Open()
    {
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        _wait.Until(d => d.FindElement(_usernameInput).Displayed);
    }

    public SecureAreaPage Login(string username, string password)
    {
        _driver.FindElement(_usernameInput).Clear();
        _driver.FindElement(_usernameInput).SendKeys(username);

        _driver.FindElement(_passwordInput).Clear();
        _driver.FindElement(_passwordInput).SendKeys(password);

        _driver.FindElement(_loginButton).Click();

        return new SecureAreaPage(_driver, _wait);
    }
}
