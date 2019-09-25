using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAHomework.Utils
{
    public class BaseTest
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriverInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                ManageDriver();
            }
            return driver;
        }

        private static void ManageDriver()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}
