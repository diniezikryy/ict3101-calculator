using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace ReqnRollCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorQualityMetricsStepDefinitions
    {
        private readonly CalculatorContext _context;

        public UsingCalculatorQualityMetricsStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press defect density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(double defects, double linesOfCode)
        {
            _context.Result = _context.Calculator.CalculateDefectDensity(defects, linesOfCode);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press SSI calculation")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSICalculation(double previousSSI, double newCode)
        {
            _context.Result = _context.Calculator.CalculateSSI(previousSSI, newCode);
        }

        [Then(@"the quality result should be (.*)")]
        public void ThenTheQualityResultShouldBe(double expected)
        {
            Assert.That(_context.Result, Is.EqualTo(expected).Within(0.001));
        }
    }
}