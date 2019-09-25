using System;
using OpenQA.Selenium;
using QAHomework.Utils;

namespace QAHomework.PageObjects
{
    public class FormPO : BasePO
    {
        public IWebElement HelloInputText => GetDriver().FindElement(By.Id("hello-input"));
        public IWebElement GoSubmitButton => GetDriver().FindElement(By.Id("hello-submit"));
        public IWebElement HelloResultText => GetDriver().FindElement(By.Id("hello-text"));

        public FormPO(IWebDriver driver)
            : base(driver)
        {
        }

        public void SendKeysHelloInputText(string text)
        {
            HelloInputText.Clear();
            HelloInputText.SendKeys(text);
        }

        public void ClickGoSubmitButton()
        {
            GoSubmitButton.Click();
        }

        public void NavigateToFormPage()
        {
            NavegateTo(Constants.FormURL);
        }

        public bool IsOnFormPage(string url)
        {
            return Constants.FormURL == url; 
        }

        public bool IsFormButtonActive()
        {
            return GetDriver().FindElement(By.CssSelector("li:nth-child(2)")).GetAttribute("class").Contains("active");
        }
    }
}
