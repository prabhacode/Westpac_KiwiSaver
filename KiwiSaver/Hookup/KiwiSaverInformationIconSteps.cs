using KiwiSaver.Global;
using KiwiSaver.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace KiwiSaver.Hookup
{
    [Binding]
    public class KiwiSaverInformationIconSteps
    {
        [Given(@"I am on the Westpac Home page")]
        public void GivenIAmOnTheWestpacHomePage()
        {
            // Inititalize();
            Base start = new Base();
            start.Initialize();


        }

        [Given(@"I click on KiwiSaver menu")]
        public void GivenIClickOnKiwiSaverMenu()
        {
            //Clicking KiiSaver menu
            Page_Home home = new Page_Home();
            home.MenuKiwiSaver.Click();
        }

        [Given(@"I click on KiwiSaver Calculator button")]
        public void GivenIClickOnKiwiSaverCalculatorButton()
        {
            //Clicking KiwiSaverCalculators Button
            Page_Home home = new Page_Home();
            GlobalDefinitions.TurnOnWait();
            home.ButtonKiwiSaverCalculators.Click();
        }

        [Given(@"I click on Click here to get started button")]
        public void GivenIClickOnClickHereToGetStartedButton()
        {
            //Clicking Click Here To Get Started button
            Page_Home home = new Page_Home();
            home.ButtonClickHereToGetStarted.Click();
        }


        [When(@"I click on information icon besides Current age")]
        public void WhenIClickOnInformationIconBesidesCurrentAge()
        {

            Page_KiwisaverCalculator informationIcon = new Page_KiwisaverCalculator();
            informationIcon.ClickInformationIcon();
        }

        [Then(@"The message should display below the current age field")]
        public void ThenTheMessageShouldDisplayBelowTheCurrentAgeField()
        {
            Page_KiwisaverCalculator validate = new Page_KiwisaverCalculator();
            validate.ValidateInformationIcon();
            GlobalDefinitions.driver.Close();

        }
    }
}
