using System;
using System.Collections.Generic;
using System.Text;
using AutomatedTest.Pages;
using AutomatedTest.Pages.Book;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomatedTest.Tests
{

    [Author("Yessica Gómez", "yegs95@gmail.com")]
    public class SearchTest: SetupDrivers
    {
        MainPage main;
        BookPage bookPage;

        [OneTimeSetUp]
        public void SetupDriver() {
            Setup();
            OpenBrowser();
            main = new MainPage(driver);
            bookPage = new BookPage(driver);
        }

        [Test]
        public void A_VerifyFirstResult() {

            main.TypeText(Config.texts.SearchPhrase);
            main.InputMainEnter();
            Assert.AreEqual(Config.texts.FirstResult, main.FirstOption.Text); 
        }

        [Test]
        public void B_VerifyFirstOptionBook()
        {
            main.FirstOption.Click();            
            Assert.AreEqual(Config.texts.SearchPhrase, bookPage.titleBookPage.Text);
       
        }

        [Test]
        public void C_PatrickPage()
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
