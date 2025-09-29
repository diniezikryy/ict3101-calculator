using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace ReqnRollCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private readonly CalculatorContext _context;

        public UsingCalculatorBasicReliabilityStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press current failure intensity")]
        public void WhenIHaveEnteredThreeValuesAndPressCurrentFailureIntensity(double p1, double p2, double p3)
        {
            _context.Result = _context.Calculator.DoOperation(p1, p2, p3, "current_failure_intensity");
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press average expected failures")]
        public void WhenIHaveEnteredThreeValuesAndPressAverageExpectedFailures(double p1, double p2, double p3)
        {
            _context.Result = _context.Calculator.DoOperation(p1, p2, p3, "average_expected_failures");
        }

        [Then(@"the reliability result should be (.*)")]
        public void ThenTheReliabilityResultShouldBe(double expected)
        {
            Assert.That(_context.Result, Is.EqualTo(expected).Within(0.01)); // Allow small floating point differences
        }
    }
}