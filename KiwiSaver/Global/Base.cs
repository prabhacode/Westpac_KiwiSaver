using KiwiSaver.Config;
using KiwiSaver.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using static KiwiSaver.Global.GlobalDefinitions;

namespace KiwiSaver.Global
{

    public class Base
    {
        public static int Browser = Int32.Parse(KiwiSaverResources.Browser);
        public static string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
        public static string ScreenshotPath = path + "\\" + KiwiSaverResources.ScreenShotPath;
        public static string ExcelPath = path + "\\" + KiwiSaverResources.ExcelPath;
        public string BaseUrl = "http://www.westpac.co.nz/";



        #region setup and tear down
        [SetUp]
        public void Initialize()
        {
            //initialize browser
            InitializeBrowser(Browser);
            driver.Navigate().GoToUrl(BaseUrl);

        }

        [TearDown]
        public void TearDown()
        {
            // End Test Report and Close the driver
            ExtentReport.AfterTest();
        }
        #endregion

        [OneTimeSetUp]
        public void BeforeTestFixture()
        {
            ExtentReport.InitializeReport();
        }

        [OneTimeTearDown]
        public void AfterTestFixture()
        {
            //end report
            ExtentReport.EndReport();
        }




    }
}