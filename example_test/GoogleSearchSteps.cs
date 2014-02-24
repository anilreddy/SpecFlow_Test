using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SpecFlowTest
{
    [Binding]
    public class GoogleSearchExampleSteps
    {
        [Given(@"I am on google page")]
        public void GivenIAmOnGooglePage()
        {
            WebBrowser.Current.Navigate().GoToUrl("http://google.com");
            WebBrowser.Current.Manage().Window.Maximize();
            Assert.AreEqual("Google", WebBrowser.Current.Title);
        }
        
        [Given(@"I search for the text (.*)")]
        public void GivenIHaveEnteredSeleniumInTheSearchField(string keyword)
        {
            IWebElement query = WebBrowser.Current.FindElement(By.Name("q"));
            query.SendKeys(keyword);
        }
        
        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            WebBrowser.Current.FindElement(By.Name("btnG")).Click();
            WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        
        [When(@"I click Selenium link")]
        public void WhenIClickSeleniumLink()
        {
            WebBrowser.Current.FindElement(By.LinkText("Selenium - Web Browser Automation")).Click();
            WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        
        [Then(@"I click Download link")]
        public void ThenIClickDownloadLink()
        {
            WebBrowser.Current.FindElement(By.LinkText("Download")).Click();
            Assert.AreEqual("Downloads", WebBrowser.Current.Title);
        }
    }
}
