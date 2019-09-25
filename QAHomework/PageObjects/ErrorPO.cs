using System;
using OpenQA.Selenium;
using QAHomework.Utils;

namespace QAHomework.PageObjects
{
    public class ErrorPO : BasePO
    {
        public IWebElement ErrorMessage => GetDriver().FindElement(By.TagName("h1"));

        public ErrorPO(IWebDriver driver)
            : base(driver)
        {
        }

        public bool IsOnErrorPage(string url)
        {
            return Constants.ErrorURL == url;
        }
    }
}
