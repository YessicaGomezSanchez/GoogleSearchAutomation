using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTest
{
    public class SetupDrivers
    {
        public IWebDriver driver;

        public void Setup()
        {
            driver = new ChromeDriver();
        }

        public void OpenBrowser()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }

        public void closeDriver()
        {
            driver.Close();
            driver.Dispose();
            driver = null;
        }


    }
}