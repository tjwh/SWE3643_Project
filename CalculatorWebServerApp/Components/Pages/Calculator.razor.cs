using Calculator;
namespace CalculatorWebServerApp.Components.Pages;

public partial class Calculator
{
    private CalculatorResult? _result = new CalculatorResult();
    private double _inputA;
    private double _inputB;

    // Method for handling the changing style of the Result Box. Thanks, Jeff :^)
    private string ResultStyle {
        get {
            if (_result == null || _result.IsSuccess) return "resultBox";
            return "resultError";
        }
    }
    
    private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

    // Clears our result when loading the page to set the default state
    protected override void OnInitialized() {
        ClearResult();
    }

    // Clears our result, all visual changes are handled via HTML binding and embedded code
    private void ClearResult() {
        _result = null;
        _inputA = 0;
        _inputB = 0;
    }
    
    private void Add() {
        _result = _calculatorEngine.Add(_inputA, _inputB);
    }

    private void Subtract() {
        _result = _calculatorEngine.Subtraction(_inputA, _inputB);
    }

    private void Multiplication() {
        _result = _calculatorEngine.Multiplication(_inputA, _inputB);
    }

    private void Division() {
        _result = _calculatorEngine.Division(_inputA, _inputB);
    }

    private void Equals() {
        _result = _calculatorEngine.Equals(_inputA, _inputB);
    }

    private void Power() {
        _result = _calculatorEngine.Power(_inputA, _inputB);
    }

    private void Logarithm() {
        _result = _calculatorEngine.Logarithm(_inputA, _inputB);
    }

    private void Root() {
        _result = _calculatorEngine.Root(_inputA, _inputB);
    }

    private void Factorial() {
        _result = _calculatorEngine.Factorial(_inputA);
    }

    private void Sine() {
        _result = _calculatorEngine.Sine(_inputA);
    }

    private void Cosine() {
        _result = _calculatorEngine.Cosine(_inputA);
    }

    private void Tangent() {
        _result = _calculatorEngine.Tangent(_inputA);
    }

    private void Reciprocal() {
        _result = _calculatorEngine.Reciprocal(_inputA);
    }
}