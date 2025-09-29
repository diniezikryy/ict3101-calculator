using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace ReqnRollCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorFactorialStepDefinitions
    {
        private readonly CalculatorContext _context;

        public UsingCalculatorFactorialStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int number)
        {
            _context.Result = _context.Calculator.Factorial(number);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double expected)
        {
            Assert.That(_context.Result, Is.EqualTo(expected));
        }
    }
}