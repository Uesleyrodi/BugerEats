using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;

namespace BugerEats
{
    public class Hooks
    {
        #region Globals

        private static ChromeDriver ChromeDriver;
        public static EventFiringWebDriver Driver;



        [TestInitialize]
        public void MyTestInitialize()
        {
            ChromeDriver = new ChromeDriver("Deploy");
            ChromeDriver.Url = "https://buger-eats.vercel.app/";
            ChromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Window.Maximize();

            Driver = new EventFiringWebDriver(ChromeDriver);
        }

        #endregion
        [TestCleanup]
        public void MyTestCleanup()
        {
            Driver.Quit();
            ChromeDriver.Quit();
        }
    }
}
