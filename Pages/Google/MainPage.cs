using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace AutomatedTest.Pages
{
    public class MainPage
    {
        public MainPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement inputMain => Driver.FindElement(By.Name("q"));

        public IWebElement FirstOption => Driver.FindElement(By.CssSelector(".g:nth-child(1) > div:nth-child(2) .LC20lb"));

        public IWebElement SelectFirstOption => Driver.FindElement(By.CssSelector(".mw-parser-output"));

        public IWebElement FirstSuggestion => Driver.FindElements(By.TagName("ul"))[0].FindElement(By.XPath("//div[2]/div/span"));

        public void TypeText(string text) {
            inputMain.SendKeys(text);
            Thread.Sleep(2000);
        }

        public void InputMainEnter() {
            inputMain.SendKeys(Keys.Return);
            Thread.Sleep(2000);
        }



    }
}
