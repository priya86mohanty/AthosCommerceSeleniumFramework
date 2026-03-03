namespace AthosCommerceSeleniumFramework.Utilities;

public static class WebDriverFactory
{
    public static IWebDriver CreateChromeDriver()
    {
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--no-sandbox");

        return new ChromeDriver(options);
    }
}
