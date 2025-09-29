using Moq;

namespace ICT3101_Calculator.UnitTests;

public class AdditionalCalculatorTests
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;
    
    [SetUp]
    public void Setup()
    {
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr => 
            fr.Read(It.IsAny<string>())).Returns(new string[] { "42", "100", "5", "-15" });
        
        _calculator = new Calculator();
    }
    
    // mock file reader tests
    [Test]
    public void GenMagicNum_WithMock_ReturnsDoubledValue()
    {
        // Pass in the mock object (not a real FileReader!)
        double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
        Assert.That(result, Is.EqualTo(84));
    }

    [Test]
    public void GenMagicNum_WithMock_SecondIndex_ReturnsCorrectValue()
    {
        double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
        Assert.That(result, Is.EqualTo(200));
    }

    [Test]
    public void GenMagicNum_WithMock_NegativeNumber_ReturnsPositiveDoubled()
    {
        double result = _calculator.GenMagicNum(3, _mockFileReader.Object);
        Assert.That(result, Is.EqualTo(30));
    }
}