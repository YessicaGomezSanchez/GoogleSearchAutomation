using System;
using System.Collections.Generic;
using System.Text;
using AutomatedTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomatedTest.Tests
{

    [Author("Yessica Gómez", "yegs95@gmail.com")]
    public class SearchTest: SetupDrivers
    {
        MainPage main;

        [OneTimeSetUp]
        public void SetupDriver() {
            Setup();
            OpenBrowser();
            main = new MainPage(driver);
        }

        [Test]
        public void VerifyFirstResult() {

            main.TypeText(Config.texts.SearachPhrase);
            main.InputMainEnter();
            IWebElement element = main.FirstOption();
            Assert.AreEqual(Config.texts.FirstResult, element.Text); 
        }

        //[Test]
        //public void VerifySuggertionFirstResult()
        //{

        //    main.inputMain.SendKeys(Config.texts.SearachPhrase);
        //    main.inputMain.SendKeys(Keys.Return);
        //    Assert.AreEqual(Config.texts.FirstResult, main.FirstOption().Text);

        //}


        [OneTimeTearDown]
        public void closeBrowser()
        {
            closeDriver();
        }

    }
}
