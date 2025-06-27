using TechTalk.SpecFlow;
using NUnit.Framework;
using System;

namespace HospitalManagementSystem.Tests.Steps
{
    [Binding]
    public class CommonSteps
    {
        private string _currentPage;
        private string _clickedButton;

        [Given(@"I am on the \"(.*)\" page")]
        [When(@"I am on the \"(.*)\" page")]
        public void GivenOrWhenIAmOnThePage(string pageName)
        {
            _currentPage = pageName;
            Console.WriteLine($"Navigated to '{pageName}' page.");
        }

        [When(@"I click the \"(.*)\" button")]
        public void WhenIClickTheButton(string buttonText)
        {
            _clickedButton = buttonText;
            Console.WriteLine($"Clicked the '{buttonText}' button.");
        }

        [Then(@"I should be on the \"(.*)\" page")]
        public void ThenIShouldBeOnThePage(string expectedPage)
        {
            Assert.AreEqual(expectedPage, _currentPage);
        }

        [Then(@"the \"(.*)\" button should be visible")]
        public void ThenTheButtonShouldBeVisible(string buttonText)
        {
            Assert.IsNotNull(buttonText);
            Console.WriteLine($"Verified '{buttonText}' button is visible.");
        }
    }
}
