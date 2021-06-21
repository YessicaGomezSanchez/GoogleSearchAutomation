using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedTest.Pages.Book
{
    public class BookPage
    {
        public BookPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement titleBookPage => Driver.FindElement(By.Id("firstHeading"));
        public IWebElement patrickLink => Driver.FindElement(By.XPath("//div[@id='mw-content-text']/div/p/a[2]"));
        

    }
}
