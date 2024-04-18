namespace Calculator;

public class CalculatorResult
{
    public double Result { get; set; } = 0.0f;
    public bool IsSuccess { get; set; }
    public string Operation { get; set; }
    public string Error { get; set; }
}