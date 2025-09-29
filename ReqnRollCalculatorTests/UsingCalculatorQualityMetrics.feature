Feature: UsingCalculatorQualityMetrics
In order to assess software quality
As a quality engineer
I want to calculate defect density and track source instructions

@QualityMetrics
Scenario: Calculate defect density
    Given I have a calculator
    When I have entered 50 and 10000 into the calculator and press defect density
    Then the quality result should be 0.005

@QualityMetrics
Scenario: Calculate SSI for successive release
    Given I have a calculator
    When I have entered 15000 and 2000 into the calculator and press SSI calculation
    Then the quality result should be 17000

@QualityMetrics
Scenario: Calculate defect density with zero defects
    Given I have a calculator
    When I have entered 0 and 5000 into the calculator and press defect density
    Then the quality result should be 0