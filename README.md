# AthosCommerce Selenium Framework

This repository contains a Selenium UI automation framework using **xUnit** and the **Page Object Model (POM)** pattern.

## Scenario Covered
- Open Chrome and navigate to `https://the-internet.herokuapp.com/login`
- Enter username: `tomsmith`
- Enter password: `SuperSecretPassword!`
- Click Login
- Verify success message contains: `You logged into a secure area!`

## Structure
- `Pages/LoginPage.cs` – Login page object interactions.
- `Pages/SecureAreaPage.cs` – Secure area page object interactions.
- `Utilities/WebDriverFactory.cs` – WebDriver creation logic.
- `Tests/TestBase.cs` – Test setup/teardown base class.
- `Tests/LoginTests.cs` – xUnit login automation test.

## Run tests
```bash
dotnet test
```
