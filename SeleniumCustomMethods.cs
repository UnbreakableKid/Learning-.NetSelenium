﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium;

public static class SeleniumCustomMethods
{
    public static void Click(this IWebElement locator)
    {
        locator.Click();
    }

    public static void Submit(this IWebElement locator)
    {
        locator.Submit();
    }

    public static void EnterText(this IWebElement locator, string text)
    {
        locator.Clear();
        locator.SendKeys(text);
    }

    public static void SelectDropDownByText(this IWebElement locator, string text)
    {
        var selectElement = new SelectElement(locator);
        selectElement.SelectByText(text);
    }

    public static void SelectDropDownByValue(this IWebElement locator, string value)
    {
        var selectElement = new SelectElement(locator);
        selectElement.SelectByValue(value);
    }
}