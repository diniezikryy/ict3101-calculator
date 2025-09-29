Feature: UsingCalculatorMusaLogarithmic
In order to predict system reliability using Musa Logarithmic model
As a reliability analyst
I want to calculate failure intensity and expected failures

@MusaLogarithmic
Scenario: Calculate Musa Logarithmic failure intensity
    Given I have a calculator
    When I have entered 10 and 50 and 0.02 into the calculator and press Musa logarithmic failure intensity
    Then the logarithmic result should be 3.68

@MusaLogarithmic
Scenario: Calculate Musa Logarithmic expected failures
    Given I have a calculator
    When I have entered 10 and 100 and 0.02 into the calculator and press Musa logarithmic expected failures
    Then the logarithmic result should be 152