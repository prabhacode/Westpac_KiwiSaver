using KiwiSaver.Global;
using KiwiSaver.Pages;
using NUnit.Framework;
using System;

namespace KiwiSaver
{
    public class NUnitTest
    {
        [TestFixture]
        [Category("KiwiSaverCalculation")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void ClickOnInformation()
            {
                //test report
                ExtentReport.test = ExtentReport.extent.StartTest("Check Information");

                //Navigate to KiwiSaver Calculator
                Page_Home navigate = new Page_Home();
                navigate.NavigationToCalculator();

                Page_KiwisaverCalculator information = new Page_KiwisaverCalculator();
                //Checking information icon
                information.ClickInformationIcon();
                information.ValidateInformationIcon();
            }

            [Test, Order(2)]
            public void KiwiSaverForEmployed()
            {
                //test report
                ExtentReport.test = ExtentReport.extent.StartTest("Calculation for Employed");

                //Navigate to KiwiSaver Calculator
                Page_Home navigate = new Page_Home();
                navigate.NavigationToCalculator();

                Page_KiwisaverCalculator calculator = new Page_KiwisaverCalculator();
                //KiwiSaver Calculation for Employed
                calculator.Employed();

            }


            [Test, Order(3)]
            public void KiwiSaverForSelfEmployed()
            {
                //test report
                ExtentReport.test = ExtentReport.extent.StartTest("Calculation for Self Employed");

                //Navigate to KiwiSaver Calculator
                Page_Home navigate = new Page_Home();
                navigate.NavigationToCalculator();

                Page_KiwisaverCalculator calculator = new Page_KiwisaverCalculator();

                //KiwiSaver Calculation for Self-Employed
                calculator.SelfEmployed();

            }


            [Test, Order(4)]
            public void KiwiSaverForNotEmployed()
            {
                //test report
                ExtentReport.test = ExtentReport.extent.StartTest("Calculation for Not Employed");

                //Navigate to KiwiSaver Calculator
                Page_Home navigate = new Page_Home();
                navigate.NavigationToCalculator();

                Page_KiwisaverCalculator calculator = new Page_KiwisaverCalculator();
                //KiwiSaver Calculation for Not Employed
                calculator.NotEmployed();

            }
        }
    }
}