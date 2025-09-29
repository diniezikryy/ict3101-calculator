Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicReliability
Scenario: Calculate current failure intensity
    Given I have a calculator
    When I have entered 10 and 50 and 100 into the calculator and press current failure intensity
    Then the reliability result should be 5

@BasicReliability
Scenario: Calculate average number of expected failures
    Given I have a calculator
    When I have entered 10 and 5 and 100 into the calculator and press average expected failures
    Then the reliability result should be 39.35