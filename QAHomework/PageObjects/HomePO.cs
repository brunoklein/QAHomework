using System;
using OpenQA.Selenium;
using QAHomework.Utils;

namespace QAHomework.PageObjects
{
    public class HomePO : BasePO
    {
        public IWebElement PText => GetDriver().FindElement(By.TagName("p"));

        public HomePO(IWebDriver driver)
           : base(driver)
        {
        }

        public void NavigateToHomePage()
        {
            NavegateTo(Constants.HomeURL);
        }

        public bool IsOnHomePage(string url)
        {
            return Constants.HomeURL == url;
        }

        public bool IsHomeButtonActive()
        {
            return GetDriver().FindElement(By.CssSelector("li:nth-child(1)")).GetAttribute("class").Contains("active");
        }
    }
}
