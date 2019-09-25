using QAHomework.PageObjects;
using QAHomework.Utils;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace QAHomework.Steps
{
    [Binding]
    public class ErrorPageSteps : BaseTest
    {
        private static ErrorPO errorPage;

        [BeforeTestRun]
        public static void Setup()
        {
            errorPage = new ErrorPO(GetDriverInstance());
        }

        [Then(@"an (.*) error code should happen")]
        public void ThenAnErrorCodeShouldHappen(int p0)
        {
            Assert.IsTrue(errorPage.ErrorMessage.Text.Contains(Constants.ErrorCode),
                "Error 404 was not returned.");
            Assert.IsTrue(errorPage.GetPageTitle.Contains(Constants.ErrorCode),
                "Error 404 was not returned.");
        }
    }
}