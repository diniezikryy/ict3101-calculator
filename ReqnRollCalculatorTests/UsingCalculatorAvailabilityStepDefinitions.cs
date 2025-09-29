using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace ReqnRollCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorAvailabilityStepDefinitions
    {
        private readonly CalculatorContext _context;

        public UsingCalculatorAvailabilityStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double totalTime, double failures)
        {
            _context.Result = _context.Calculator.CalculateMTBF(totalTime, failures);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double mtbf, double mttr)
        {
            _context.Result = _context.Calculator.CalculateAvailability(mtbf, mttr);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double expected)
        {
            Assert.That(_context.Result, Is.EqualTo(expected));
        }
    }
}