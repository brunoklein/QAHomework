using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAHomework.PageObjects
{
    public class BasePO
    {
        private readonly IWebDriver driver;
        public IWebDriver GetDriver() => driver;
        public IWebElement DHLogo => driver.FindElement(By.Id("dh_logo"));
        public IWebElement UITestingButton => driver.FindElement(By.Id("site"));
        public IWebElement HomeButton => driver.FindElement(By.Id("home"));
        public IWebElement FormButton => driver.FindElement(By.Id("form"));
        public IWebElement ErrorButton => driver.FindElement(By.Id("error"));
        public IWebElement HeadingText => driver.FindElement(By.TagName("h1"));
        public string GetPageTitle => driver.Title;

        public BasePO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickUITestingButton()
        {
            UITestingButton.Click();
        }

        public void ClickHomeButton()
        {
            HomeButton.Click();
        }

        public void ClickFormButton()
        {
            FormButton.Click();
        }

        public void ClickErrorButton()
        {
            ErrorButton.Click();
        }

        public void NavegateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseDriver()
        {
            driver.Dispose();
        }
    }
}