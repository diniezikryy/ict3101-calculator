namespace ICT3101_Calculator.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }

    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
    {
        // Act
        double result = _calculator.Subtract(30, 10);
        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
    {
        // Act: Call the Divide method with two numbers.
        double result = _calculator.Divide(20, 10);
        // Assert: Check if the result is the expected quotient.
        Assert.That(result, Is.EqualTo(2));
    }

    // [Test]
    // public void Divide_WhenDividingByZero_ResultThrowArgumentException() // Renamed for clarity
    // {
    //     // Assert that calling Divide with a zero divisor throws an ArgumentException.
    //     Assert.That(() => _calculator.Divide(15, 0), Throws.ArgumentException);
    // }

    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
    {
        // Act: Call the Multiply method with two numbers.
        double result = _calculator.Multiply(5, 5);
        // Assert: Check if the result is the expected product.
        Assert.That(result, Is.EqualTo(25));
    }

    // [TestCase(0, 0)]
    // [TestCase(10, 0)]
    // public void Divide_WithZeroAsInputs_ResultThrowArgumentException(double a, double b)
    // {
    //     Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    // }

    [Test]
    public void Factorial_WhenCalculatingFactorialOfThree_ResultEqualToSix()
    {
        double result = _calculator.Factorial(3);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Factorial_WithNegativeNumber_ThrowsArgumentException()
    {
        // Assert
        Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
    }

    [Test]
    public void Factorial_WithZero_ReturnsOne()
    {
        double result = _calculator.Factorial(0);
        Assert.That(result, Is.EqualTo(1));
    }

    [TestCase(5, 10, 25)]
    [TestCase(2, 3, 3)]
    [TestCase(10, 0, 0)]
    [TestCase(0, 5, 0)]
    public void AreaOfTriangle_WhenCalculatingArea_ResultEqualToExpected(int length, int height, double expected)
    {
        Assert.That(() => _calculator.AreaOfTriangle(length, height), Is.EqualTo(expected));
    }
    
    [Test]
    public void AreaOfCircle_WithNegativeRadius_ThrowsArgumentException()
    {
        // Assert that a negative radius throws an exception
        Assert.That(() => _calculator.AreaOfCircle(-5), Throws.ArgumentException);
    }
    
    [TestCase(1, Math.PI)]
    [TestCase(0, 0)]
    public void AreaOfCircle_WhenCalculatingArea_ResultEqualToExpected(int radius, double expected)
    {   
        // Act
        double result = _calculator.AreaOfCircle(radius);
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }
    
    [Test]
    public void AreaOfTriangle_WithNegativeInput_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.AreaOfTriangle(-5, 10), Throws.ArgumentException);
    
        Assert.That(() => _calculator.AreaOfTriangle(5, -10), Throws.ArgumentException);
    }
    
    // UnknownFunctionA tests
    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(60));
    }
    
    [Test]
    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }
    
    // UnknownFunctionB tests
    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4,5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4,5), Throws.ArgumentException);
    }
    
    // GenMagicNum tests
    // [Test]
    // public void GenMagicNum_WithValidInput_ReturnsDoubledValue()
    // {
    //     // Now we pass in a real FileReader
    //     FileReader fileReader = new FileReader();
    //     double result = _calculator.GenMagicNum(0, fileReader);
    //     Assert.That(result, Is.EqualTo(84));
    // }
    //
    // [Test]
    // public void GenMagicNum_WithSecondIndex_ReturnsCorrectValue()
    // {
    //     FileReader fileReader = new FileReader();
    //     double result = _calculator.GenMagicNum(1, fileReader);
    //     Assert.That(result, Is.EqualTo(200));
    // }
    //
    // [Test]
    // public void GenMagicNum_WithNegativeNumberInFile_ReturnsPositiveDoubled()
    // {
    //     FileReader fileReader = new FileReader();
    //     double result = _calculator.GenMagicNum(3, fileReader);
    //     Assert.That(result, Is.EqualTo(30));
    // }
    //
    // [Test]
    // public void GenMagicNum_WithOutOfBoundsIndex_ReturnsZero()
    // {
    //     FileReader fileReader = new FileReader();
    //     double result = _calculator.GenMagicNum(10, fileReader);
    //     Assert.That(result, Is.EqualTo(0));
    // }
}