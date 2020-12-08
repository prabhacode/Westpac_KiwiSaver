using KiwiSaver.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KiwiSaver.Pages
{

    class Page_Home
    {
        public Page_Home()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Employment Status");
        }

        #region Initialize Web Elements 

        //Kiwisaver
        public IWebElement MenuKiwiSaver => GlobalDefinitions.driver.FindElement(By.XPath("//a[@id='ubermenu-section-link-kiwisaver-ps']"));



        //Kiwisaver Calculator
        public IWebElement ButtonKiwiSaverCalculators => GlobalDefinitions.driver.FindElement(By.XPath("//a[@id='ubermenu-item-cta-kiwisaver-calculators-ps']"));


        //Click here to get started button
        public IWebElement ButtonClickHereToGetStarted => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Click here to get started.')]"));


        #endregion

        internal void NavigationToCalculator()
        {
            GlobalDefinitions.TurnOnWait();
            MenuKiwiSaver.Click();
            ButtonKiwiSaverCalculators.Click();
            Thread.Sleep(2000);
            ButtonClickHereToGetStarted.Click();

        }

    }
}
