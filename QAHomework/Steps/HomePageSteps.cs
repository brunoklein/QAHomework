using System;
using QAHomework.PageObjects;
using QAHomework.Utils;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace QAHomework.Steps
{
    [Binding]
    public class HomePageSteps : BaseTest
    {
        private static HomePO homePage;
        private static FormPO formPage;

        [BeforeTestRun]
        public static void Setup()
        {
            homePage = new HomePO(GetDriverInstance());
            formPage = new FormPO(GetDriverInstance());
        }

        [Given(@"an user access Home Page")]
        public void GivenAnUserAccessHomePage()
        {
            homePage.NavigateToHomePage();
        }

        [Given(@"an user is on Home Page")]
        public void GivenAnUserIsOnHomePage()
        {
            Assert.IsTrue(homePage.IsOnHomePage(GetDriverInstance().Url),
                "Home page was not displayed");
        }

        [When(@"I click on UITesting button")]
        public void WhenIClickOnUITestingButton()
        {
            homePage.ClickUITestingButton();
        }

        [Then(@"Home button is active")]
        public void ThenHomeButtonIsActive()
        {
            Assert.IsTrue(homePage.IsHomeButtonActive(),
                "Home button was not active");
            Assert.IsFalse(formPage.IsFormButtonActive(),
                "Form button was active");
        }
        
        [Then(@"Home Page is displayed")]
        public void ThenHomePageIsDisplayed()
        {
            Assert.IsTrue(homePage.IsOnHomePage(GetDriverInstance().Url),
                "Home page was not displayed.");
        }

        [Then(@"message ""(.*)"" in ""(.*)"" tag")]
        public void ThenMessageInTag(string p0, string p1)
        {
            var element = p1 == "h1" ? homePage.HeadingText : homePage.PText;
            Assert.AreEqual(p0, element.Text);
            Assert.AreEqual(p1, element.TagName);
        }
    }
}
