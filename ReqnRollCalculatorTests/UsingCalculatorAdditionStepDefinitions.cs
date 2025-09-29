using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace ReqnRollCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorAdditionStepDefinitions
    {
        private readonly CalculatorContext _context;

        public UsingCalculatorAdditionStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // calculator already created in context constructor
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _context.Result = _context.Calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_context.Result, Is.EqualTo(p0));
        }
    }
}