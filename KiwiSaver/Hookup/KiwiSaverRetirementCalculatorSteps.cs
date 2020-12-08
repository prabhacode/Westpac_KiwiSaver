using KiwiSaver.Global;
using KiwiSaver.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace KiwiSaver.Hookup
{
    [Binding]
    public class KiwiSaverRetirementCalculatorSteps
    {
        [When(@"I add KiwiSaver details for Employed")]
        public void WhenIAddKiwiSaverDetailsForEmployed()
        {
            Page_KiwisaverCalculator employed = new Page_KiwisaverCalculator();
            employed.Employed();
        }

        [When(@"I click on View your KiwiSaver retirement projection button")]
        public void WhenIClickOnViewYourKiwiSaverRetirementProjectionButton()
        {
            Page_KiwisaverCalculator.btnKiwisaverProjection.Click();
        }

        [When(@"I add KiwiSaver details for Self-Employed")]
        public void WhenIAddKiwiSaverDetailsForSelf_Employed()
        {
            Page_KiwisaverCalculator selfEmployed = new Page_KiwisaverCalculator();
            selfEmployed.SelfEmployed();
        }

        [When(@"I add KiwiSaver details for Not Employed")]
        public void WhenIAddKiwiSaverDetailsForNotEmployed()
        {
            Page_KiwisaverCalculator notEmployed = new Page_KiwisaverCalculator();
            notEmployed.NotEmployed();
        }

        [Then(@"The button View your KiwiSaver retirement projection should be visible")]
        public void ThenTheButtonViewYourKiwiSaverRetirementProjectionShouldBeVisible()
        {
            Page_KiwisaverCalculator validate = new Page_KiwisaverCalculator();
            validate.ValidateButtonView();

        }

        [Then(@"The projected balance at retirement should be displayed")]
        public void ThenTheProjectedBalanceAtRetirementShouldBeDisplayed()
        {
            Page_KiwisaverCalculator validate = new Page_KiwisaverCalculator();
            validate.ValidateProjectedBalance();
            GlobalDefinitions.driver.Close();
        }
    }
}
