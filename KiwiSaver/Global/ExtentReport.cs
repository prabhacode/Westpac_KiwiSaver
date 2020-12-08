﻿using KiwiSaver.Config;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RazorEngine.Compilation.ImpromptuInterface;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using static KiwiSaver.Global.GlobalDefinitions;
using System.IO;
using System.Diagnostics;
//using AventStack.ExtentReports;

namespace KiwiSaver.Global
{
    [TestFixture]
    public class ExtentReport
    {
        // instance of extent reports
        public static ExtentTest test;
        public static ExtentReports extent;


        //paths for the reports
        public static string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
        public static string ReportPath = path + "\\" + KiwiSaverResources.ReportPath;
        public static string ReportXmlPath = path + "\\" + KiwiSaverResources.ReportXMLPath;



        //OneTimeSetup
        public static void InitializeReport()
        {
            //Boolean value for replacing exisisting report
            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);


            //Add QA system info to html report
            extent.AddSystemInfo("Host Name", "KiwiSaver")

    .AddSystemInfo("Environment", "YourQAEnvironment")

    .AddSystemInfo("Username", "Prabhakaran Ganesan");


            extent.LoadConfig(ReportXmlPath);
        }

        //TearDown
        public static void AfterTest()
        {
            try
            {
                //StackTrace details for failed Testcases

                var status = TestContext.CurrentContext.Result.Outcome.Status;

                var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
                var errorMessage = TestContext.CurrentContext.Result.Message;

                if (status == TestStatus.Failed)
                {

                    String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Capture");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");

                    test.Log(LogStatus.Fail, status + errorMessage);

                    test.Log(LogStatus.Fail, status + "Image example: " + img);

                }

                else if (status == TestStatus.Passed)
                {

                    String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Capture");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");

                    test.Log(LogStatus.Pass, "Test Passed");
                }

                else if (status == TestStatus.Skipped)
                {

                    String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Capture");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");

                    test.Log(LogStatus.Skip, "Test Skipped");
                }
                //End test report

                extent.EndTest(test);
                driver.Quit();


            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //OneTimeTearDown
        public static void EndReport()
        {

            //End Report

            extent.Flush();

            extent.Close();

        }
    }




}

