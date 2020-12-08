using KiwiSaver.Global;
using Microsoft.Office.Interop.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwiSaver.Pages
{
    class Page_KiwisaverCalculator
    {
        public Page_KiwisaverCalculator()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Employment Status");
        }

        #region Initialize Web Elements 

        //Info icon_Current age
        private IWebElement IconAgeInformation => GlobalDefinitions.driver.FindElement(By.XPath("//div[@help-id='CurrentAge']//button[@type='button']"));

        //Current Age textbox
        private IWebElement txtCurrentAge => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Current age']//input[@class='ng-pristine ng-valid']"));

        String formName => GlobalDefinitions.driver.FindElement(By.XPath("//h1[contains(text(),'KiwiSaver Retirement Calculator')]")).Text;

        String actualMessage => GlobalDefinitions.driver.FindElement(By.XPath("//div[@ng-if='frameless']//div[@class='field-message message-info ng-binding']")).Text;

        private IWebElement messageBox => GlobalDefinitions.driver.FindElement(By.XPath("//div[@ng-if='frameless']//div[@class='field-message message-info ng-binding']"));


        //Employment Status dropdown)
        private IWebElement ddEmploymentStatus => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Employment status']//div[@ng-bind-html='selectedContent']"));

        //Dropdown List_Employed
        private IWebElement ddlEmployed => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Employment status']//li[@value='employed']"));


        //Dropdown List_Self-Employed
        private IWebElement ddlSelfEmployed => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Employment status']//li[@value='self-employed']"));


        //Dropdown List_Not Employed
        private IWebElement ddlNotEmployed => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Employment status']//li[@value='not-employed']"));


        //salary
        private IWebElement txtSalary => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Salary or wages per year (before tax)']//input[@class='ng-pristine ng-valid']"));


        //KiwiSaver Contribution - Radio button_3%
        private IWebElement rdoKiwiSaverContribution_3 => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-04C']"));


        //KiwiSaver Contribution - Radio button_4%
        private IWebElement rdoKiwiSaverContribution_4 => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-04F']"));


        //KiwiSaver Contribution - Radio button_6%
        private IWebElement rdoKiwiSaverContribution_6 => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-04I']"));


        //KiwiSaver Contribution - Radio button_8%
        private IWebElement rdoKiwiSaverContribution_8 => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-04L']"));


        //KiwiSaver Contribution - Radio button_10%
        private IWebElement rdoKiwiSaverContribution_10 => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-04O']"));


        //Current KiwiSaver balance
        private IWebElement txtCurrentKiwiSaverBalance => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Current KiwiSaver balance']//input[@placeholder='Optional']"));


        //Voluntary contributions
        private IWebElement txtVoluntaryContributions => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Voluntary contributions']//input[@placeholder='Optional']"));


        //Frequency dropdown)
        private IWebElement ddFrequency => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Voluntary contributions']//div[@ng-bind-html='selectedContent']"));


        //Dropdown List_Fortnightly
        private IWebElement ddlFortnightly => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Voluntary contributions']//li[@value='fortnight']"));


        //Dropdown List_Annually
        private IWebElement ddlAnnually => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Voluntary contributions']//li[@value='year']"));


        //Risk Profile-Radio button_Defensive
        private IWebElement rdoDefensive => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-013']"));


        //Risk Profile-Radio button_Conservative
        private IWebElement rdoConservative => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-016']"));


        //Risk Profile-Radio button_Balanced
        private IWebElement rdoBalanced => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-019']"));


        //Risk Profile-Radio button_Growth
        private IWebElement rdoGrowth => GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='radio-option-01C']"));


        //Savings goal at retirement
        private IWebElement txtSavingsGoal => GlobalDefinitions.driver.FindElement(By.XPath("//div[@label='Savings goal at retirement']//input[@placeholder='Optional']"));


        //View your KiwiSaver retirement projections
        public static IWebElement btnKiwisaverProjection => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='field-group-set']//button[@class='btn btn-regular btn-results-reveal btn-has-chevron']"));

        private IWebElement projectedBalance => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='results-heading']"));

        #endregion

        public void ClickInformationIcon()
        {
            Thread.Sleep(3000);
            GlobalDefinitions.driver.SwitchTo().Frame(0);
            Assert.That(IconAgeInformation.Enabled);
            IconAgeInformation.Click();
        }

        public void ValidateInformationIcon()
        {
            Assert.That(messageBox.Displayed);
            string expectedMessage = "This calculator has an age limit of 64 years old as you need to be under the age of 65 to join KiwiSaver.";
            AssertHelper.AreEqual(expectedMessage, actualMessage);

        }

        public void ValidateButtonView()
        {
            Assert.That(btnKiwisaverProjection.Displayed);
        }

        public void ValidateProjectedBalance()
        {
            Assert.That(projectedBalance.Displayed);

        }

        public void Employed()
        {

            Thread.Sleep(3000);
            Assert.AreEqual("KiwiSaver Retirement Calculator", formName);
            
            GlobalDefinitions.TurnOnWait();
            GlobalDefinitions.driver.SwitchTo().Frame(0);

            txtCurrentAge.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Currrent Age"));

            ddEmploymentStatus.Click();
            GlobalDefinitions.TurnOnWait();

            ddlEmployed.Click();
            GlobalDefinitions.TurnOnWait();

            txtSalary.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Salary"));

            //Selecting KiwiSaver Contribution
            var empKiwiSaverContribution = GlobalDefinitions.ExcelLib.ReadData(2, "Kiwisaver Contribution(%)");

            if (empKiwiSaverContribution == "3")
            {
                rdoKiwiSaverContribution_3.Click();
            }
            else if (empKiwiSaverContribution == "4")
            {
                rdoKiwiSaverContribution_4.Click();
            }
            else if (empKiwiSaverContribution == "6")
            {
                rdoKiwiSaverContribution_6.Click();
            }
            else if (empKiwiSaverContribution == "8")
            {
                rdoKiwiSaverContribution_8.Click();
            }
            else
            {
                rdoKiwiSaverContribution_10.Click();
            }

            rdoDefensive.Click();
        }

        internal void SelfEmployed()
        {

            Thread.Sleep(3000);
            Assert.AreEqual("KiwiSaver Retirement Calculator", formName);
            GlobalDefinitions.TurnOnWait();

            GlobalDefinitions.driver.SwitchTo().Frame(0);

            txtCurrentAge.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Currrent Age"));

            ddEmploymentStatus.Click();
            GlobalDefinitions.TurnOnWait();


            ddlSelfEmployed.Click();
            GlobalDefinitions.TurnOnWait();


            txtCurrentKiwiSaverBalance.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Current KiwiSaver Balance"));
            txtVoluntaryContributions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Voluntary  Contributions"));
            ddFrequency.Click();
            ddlFortnightly.Click();
            rdoConservative.Click();
            txtSavingsGoal.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Savings goal at retirement"));

        }

        internal void NotEmployed()
        {
            Thread.Sleep(3000);

            Assert.AreEqual("KiwiSaver Retirement Calculator", formName);
            GlobalDefinitions.TurnOnWait();

            GlobalDefinitions.driver.SwitchTo().Frame(0);

            txtCurrentAge.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Currrent Age"));
            ddEmploymentStatus.Click();
            GlobalDefinitions.TurnOnWait();

            ddlNotEmployed.Click();
            GlobalDefinitions.TurnOnWait();

            txtCurrentKiwiSaverBalance.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Current KiwiSaver Balance"));
            txtVoluntaryContributions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Voluntary  Contributions"));
            ddFrequency.Click();
            ddlAnnually.Click();
            rdoBalanced.Click();
            txtSavingsGoal.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Savings goal at retirement"));

        }
    }
}
