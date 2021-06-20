using AutomatedTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedTest.Tests
{
    [Author("Yessica Gómez", "yegs95@gmail.com")]
    public class SearchSuggestionTest: SetupDrivers
    {
        MainPage main; 

        [OneTimeSetUp]
        public void SetupDriver()
        {
            Setup();
            OpenBrowser();
            main = new MainPage(driver);
        }

        //[Test]
        public void VerifyFirstResult()
        {
            main.TypeText(Config.texts.SuggestionPhrase);
            main.FirstSuggestion.Click();
            //Assert.AreEqual(Config.texts.FirstResult, main.FirstOption().Text);
        }


        [OneTimeTearDown]
        public void closeBrowser()
        {
            closeDriver();
        }

    }
}
