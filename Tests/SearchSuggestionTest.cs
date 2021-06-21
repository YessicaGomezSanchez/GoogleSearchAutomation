using AutomatedTest.Pages;
using AutomatedTest.Pages.Book;
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
        BookPage bookPage;

        [OneTimeSetUp]
        public void SetupDriver()
        {
            Setup();
            OpenBrowser();
            main = new MainPage(driver);
            bookPage = new BookPage(driver);
        }

        [Test]
        public void A_VerifyFirstResultSuggestion()
        {
            main.TypeText(Config.texts.SuggestionPhrase);
            main.FirstSuggestion.Click();
            Assert.AreEqual(Config.texts.FirstResult, main.FirstOption.Text);
        }

        [Test]
        public void B_VerifyFirstOptionBookSuggestion()
        {
            main.FirstOption.Click();
            Assert.AreEqual(Config.texts.SearchPhrase, bookPage.titleBookPage.Text);

        }

        [Test]
        public void C_PatrickPageSuggestion()
        {
            bookPage.patrickLink.Click();
            Assert.AreEqual(Config.texts.patrickNamePage, bookPage.titleBookPage.Text);

        }
        [OneTimeTearDown]
        public void closeBrowser()
        {
            closeDriver();
        }

    }
}
