using System;
using QAHomework.Utils;
using QAHomework.PageObjects;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace QAHomework.Steps
{
    [Binding]
    public class BaseSteps : BaseTest
    {
        private static BasePO basePO;

        [BeforeTestRun]
        public static void Setup()
        {
            basePO = new BasePO(GetDriverInstance());
        }

        [Then(@"Docler Holding logo is present")]
        public void ThenDoclerHoldingLogoIsPresent()
        {
            Assert.IsTrue(basePO.DHLogo.Displayed, "Docler Holding logo was not present.");
        }

        [Then(@"title should be ""(.*)""")]
        public void ThenTitleShouldBe(string p0)
        {
            Assert.AreEqual(p0, basePO.GetPageTitle);
        }

        [When(@"I click on Home button")]
        public void WhenIClickOnHomeButton()
        {
            basePO.ClickHomeButton();
        }

        [When(@"I click on Form button")]
        public void WhenIClickOnFormButton()
        {
            basePO.ClickFormButton();
        }

        [When(@"I click on Error button")]
        public void WhenIClickOnErrorButton()
        {
            basePO.ClickErrorButton();
        }

        [AfterTestRun]
        public static void CleanUp()
        {
            basePO.CloseDriver();
        }
    }
}
