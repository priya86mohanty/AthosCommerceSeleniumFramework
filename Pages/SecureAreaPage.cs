namespace AthosCommerceSeleniumFramework.Pages;

public class SecureAreaPage
{
    private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;

    private readonly By _flashMessage = By.Id("flash");

    public SecureAreaPage(IWebDriver driver, WebDriverWait wait)
    {
        _driver = driver;
        _wait = wait;
    }

    public string GetFlashMessageText()
    {
        var flash = _wait.Until(d => d.FindElement(_flashMessage));
        return flash.Text.Trim();
    }
}
