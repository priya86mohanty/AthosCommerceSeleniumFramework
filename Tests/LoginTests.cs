using AthosCommerceSeleniumFramework.Pages;

namespace AthosCommerceSeleniumFramework.Tests;

public class LoginTests : TestBase
{
    [Fact]
    public void Login_WithValidCredentials_DisplaysSuccessMessage()
    {
        var loginPage = new LoginPage(Driver, Wait);
        loginPage.Open();

        var secureAreaPage = loginPage.Login("tomsmith", "SuperSecretPassword!");
        var flashMessage = secureAreaPage.GetFlashMessageText();

        Assert.Contains("You logged into a secure area!", flashMessage);
    }
}
