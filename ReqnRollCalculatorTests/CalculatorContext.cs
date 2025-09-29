using ICT3101_Calculator;

namespace ReqnRollCalculatorTests;

public class CalculatorContext
{
    public Calculator Calculator { get; set; }
    public double Result { get; set; }
    public double Parameter1 { get; set; }
    public double Parameter2 { get; set; }
    public double Parameter3 { get; set; }
    
    public CalculatorContext()
    {
        Calculator = new Calculator();
    }
}