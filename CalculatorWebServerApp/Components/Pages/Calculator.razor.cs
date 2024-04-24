using Calculator;
using System.Text.RegularExpressions;
namespace CalculatorWebServerApp.Components.Pages;

public partial class Calculator
{
    private CalculatorResult? _result = new CalculatorResult();
    private string _inputA;
    private string _inputB;

    // Helper method to test if our input contains anything but numbers, ., or -.
    private bool TestInputValidity(string input) {
        string pattern = @"^[0-9\.\-]+$";
        
        if (Regex.IsMatch(input, pattern)) {
            return true;
        }

        return false;
    }
    
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
        _inputA = "0";
        _inputB = "0";
    }
    
    // Helper method to quickly setup Invalid Input returns
    private CalculatorResult InvalidInputCreator(string operation) {
        return new CalculatorResult {
            Result = 0,
            IsSuccess = false,
            Operation = operation,
            Error = "Invalid Input: Numbers Only"
        };
    }
    
    private void Add()
    {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Add(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} + {_inputB}");
    }

    private void Subtract() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Subtraction(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} - {_inputB}");
    }

    private void Multiplication() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Multiplication(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} * {_inputB}");
    }

    private void Division() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Division(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} / {_inputB}");
    }

    private void Equals() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Equals(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} == {_inputB}");
    }

    private void Power() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Power(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} ^ {_inputB}");
    }

    private void Logarithm() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Logarithm(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} log {_inputB}");
    }

    private void Root() {
        if (TestInputValidity(_inputA) && TestInputValidity(_inputB)) {
            _result = _calculatorEngine.Root(Convert.ToDouble(_inputA), Convert.ToDouble(_inputB));
        }

        else _result = InvalidInputCreator($"{_inputA} root {_inputB}");
    }

    private void Factorial() {
        if (TestInputValidity(_inputA)) {
            _result = _calculatorEngine.Factorial(Convert.ToDouble(_inputA));
        }

        else _result = InvalidInputCreator($"{_inputA} !");
    }

    private void Sine() {
        if (TestInputValidity(_inputA)) {
            _result = _calculatorEngine.Sine(Convert.ToDouble(_inputA));
        }

        else _result = InvalidInputCreator($"sin({_inputA})");
    }

    private void Cosine() {
        if (TestInputValidity(_inputA)) {
            _result = _calculatorEngine.Cosine(Convert.ToDouble(_inputA));
        }

        else _result = InvalidInputCreator($"cos({_inputA})");
    }

    private void Tangent() {
        if (TestInputValidity(_inputA)) {
            _result = _calculatorEngine.Tangent(Convert.ToDouble(_inputA));
        }

        else _result = InvalidInputCreator($"tan({_inputA})");
    }

    private void Reciprocal() {
        if (TestInputValidity(_inputA)) {
            _result = _calculatorEngine.Reciprocal(Convert.ToDouble(_inputA));
        }

        else _result = InvalidInputCreator($"1 / {_inputA}");
    }
}