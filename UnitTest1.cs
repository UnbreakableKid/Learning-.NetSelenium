using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace DotnetSelenium;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EaWebSiteTest()
    {
        IWebDriver driver = new EdgeDriver();
        driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");
        LoginPage loginPage = new LoginPage(driver);
        loginPage.ClickLogin();
        loginPage.Login("admin", "password");
    }
}