using OpenQA.Selenium;

namespace DotnetSelenium.Pages;

public class LoginPage(ISearchContext driver)
{
    private IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));
    private IWebElement TxtUser => driver.FindElement(By.Id("UserName"));
    private IWebElement TxtPassword => driver.FindElement(By.Id("Password"));
    private IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));

    public void ClickLogin()
    {
        LoginLink.Click();
    }

    public void Login(string username, string password)
    {
        TxtUser.EnterText(username);
        TxtPassword.EnterText(password);
        BtnLogin.Submit();
    }

}