using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace AutomatedTest.Pages
{
    public class MainPage
    {
        WebDriverWait wait;

        public MainPage(IWebDriver webDriver)
        {
            Driver = webDriver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        private IWebDriver Driver { get; }

        public IWebElement inputMain => Driver.FindElement(By.Name("q"));

        public void TypeText(string text) { 
             inputMain.SendKeys(text);
             //Thread.Sleep(2000);
        } 

        public void InputMainEnter() {
            inputMain.SendKeys(Keys.Return); 
            Thread.Sleep(4000);
        }

        public IWebElement FirstOption()=> Driver.FindElement(By.XPath("//div[@data-hveid='CAIQAA']//div[@class='tF2Cxc']//div[@class='yuRUbf']/a/h3"));

        // public IWebElement FirstOption()=>  wait.Until(e => e.FindElement(By.XPath("//div[@data-hveid='CAIQAA']//div[@class='tF2Cxc']//div[@class='yuRUbf']/a/h3")));

        public IWebElement FirstSuggestion => Driver.FindElement(By.XPath("//li[@class='sbct sbre sbhl']//div[@class='eIPGRd']"));
       

    }
}
