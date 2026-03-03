namespace AthosCommerceSeleniumFramework.Tests;

public abstract class TestBase : IDisposable
{
    protected readonly IWebDriver Driver;
    protected readonly WebDriverWait Wait;

    protected TestBase()
    {
        Driver = Utilities.WebDriverFactory.CreateChromeDriver();
        Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
    }

    public void Dispose()
    {
        Driver.Quit();
        Driver.Dispose();
        GC.SuppressFinalize(this);
    }
}
