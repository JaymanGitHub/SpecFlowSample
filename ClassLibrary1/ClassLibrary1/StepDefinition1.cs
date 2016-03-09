using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Unit_Testing_Project;

namespace ClassLibrary1
{
    [Binding]
    public sealed class StepDefinition1
    {

        private int Result { get; set; }
        private readonly Class1 _class1 = new Class1();
        private string Name { get; set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheClass1(int number)
        {
            _class1.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheClass1(int number)
        {
            _class1.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Result = _class1.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, Result);
        }

        [Given(@"I enter a name (.*)")]
        public void GivenaName(string name)
        {
            _class1.MyName = name;
        }

        [When(@"I press getname")]
        public void WhenIPressGetName()
        {
            Name = _class1.Getname();
        }

        [Then(@"my name is (.*)")]
        public void ThenTheResultIs(string name)
        {
            Assert.AreEqual(name, Name);
        }
    }
}
