using QAHomework.PageObjects;
using QAHomework.Utils;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;

namespace QAHomework.Steps
{
    [Binding]
    public class FormPageSteps : BaseTest
    {
        private static HomePO homePage;
        private static FormPO formPage;

        [BeforeTestRun]
        public static void Setup()
        {
            homePage = new HomePO(GetDriverInstance());
            formPage = new FormPO(GetDriverInstance());
        }

        [Given(@"an user access Form Page")]
        public void GivenAnUserAccessFormPage()
        {
            formPage.NavigateToFormPage();
        }

        [Then(@"Form button is active")]
        public void ThenFormButtonIsActive()
        {
            Assert.IsTrue(formPage.IsFormButtonActive(),
                 "Form button was not active");
            Assert.IsFalse(homePage.IsHomeButtonActive(),
                "Home button was active");
        }

        [Given(@"Form Page is displayed")]
        public void GivenFormPageIsDisplayed()
        {
            Assert.IsTrue(formPage.IsOnFormPage(GetDriverInstance().Url), "Form page was not displayed.");
        }

        [Then(@"Form Page is displayed")]
        public void ThenFormPageIsDisplayed()
        {
            Assert.IsTrue(formPage.IsOnFormPage(GetDriverInstance().Url),
                "Form page was not displayed.");
        }

        [Then(@"user can see one input box")]
        public void ThenUserCanSeeOneInputBox()
        {
            int count = 0;
            var inputs = GetDriverInstance().FindElements(By.TagName("input"));

            foreach (var item in inputs)
            {
                if (item.GetAttribute("type").Contains("text"))
                {
                    count++;
                }
            }

            Assert.AreEqual(1, count, "Mismatch on Input Textbox");
        }

        [Then(@"one submit button")]
        public void ThenOneSubmitButton()
        {
            int count = 0;
            var buttons = GetDriverInstance()
                .FindElements(By.TagName("button"));

            foreach (var item in buttons)
            {
                if (item.GetAttribute("type").Contains("submit"))
                {
                    count++;
                }
            }

            Assert.AreEqual(1, count, "Mismatch on Submit Button");
        }

        [Given(@"an user enter the (.*)")]
        public void GivenAnUserEnterThe(string p0)
        {
            formPage.SendKeysHelloInputText(p0);
        }

        [When(@"I click on Go button")]
        public void WhenIClickOnGoButton()
        {
            formPage.ClickGoSubmitButton();
        }

        [Then(@"a message ""(.*)"" is displayed")]
        public void ThenAMessageIsDisplayed(string p0)
        {
            Assert.AreEqual(p0, formPage.HelloResultText.Text);
        }
    }
}
