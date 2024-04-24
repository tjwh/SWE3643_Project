using Calculator;

public class CalculatorEngine {
    private static readonly CalculatorResult Result = new CalculatorResult();

    private void ClearResult()
    {
        Result.Result = 0;
        Result.Operation = "";
        Result.Error = "";
        Result.IsSuccess = false;
    }
    
    public CalculatorResult Add(double inputA, double inputB) {
        // preq-ENGINE-3
        Result.Operation = $"{inputA} + {inputB}";
        Result.Result = inputA + inputB;
        Result.Error = null;
        Result.IsSuccess = true;
        
        return Result;
    }

    public CalculatorResult Subtraction(double inputA, double inputB) {
        // preq-ENGINE-4
        Result.Result = inputA - inputB;
        Result.Operation = $"{inputA} - {inputB}";
        Result.Error = null;
        Result.IsSuccess = true;
        
        return Result;
    }

    public CalculatorResult Multiplication(double inputA, double inputB) {
        // preq-ENGINE-5
        Result.Result = inputA * inputB;
        Result.Operation = $"{inputA} * {inputB}";
        Result.Error = null;
        Result.IsSuccess = true;
        
        return Result;
    }

    // Division method. Has logic to catch division by 0
    public CalculatorResult Division(double inputA, double inputB) {
        // preq-ENGINE-7
        ClearResult();
        
        Result.Operation = $"{inputA} / {inputB}";
        
        // If input B is 0, that means the user is trying to divide by 0..
        if (inputB == 0) {
            Result.Result = 0;
            Result.Error = "Not a Number";
            Result.IsSuccess = false;
            return Result;
        }
        
        Result.Result = Math.Round(inputA / inputB, 8);
        Result.IsSuccess = true;
        Result.Error = null;
        return Result;
    }

    // Equals method. Compares two numbers equality within a given tolerance value
    // Returns 1 when equal, 0 when not
    public CalculatorResult Equals(double inputA, double inputB) {
        // preq-ENGINE-8
        // Definitions for tolerance math
        double tolerance = 0.000000001; // Math.Pow was returning scientific notation, idk how to make it not LOL
        double absoluteValueOfDiff = Math.Abs(inputA - inputB);
        bool isWithinTolerance = absoluteValueOfDiff <= tolerance;

        Result.Operation = $"{inputA} == {inputB}";
        Result.Error = null;

        if (isWithinTolerance) {
            Result.Result = 1;
            Result.IsSuccess = true;
            return Result;
        }
        
        Result.Result = 0;
        Result.IsSuccess = true;
        return Result;
    }

    public CalculatorResult Power(double inputA, double inputB) {
        // preq-ENGINE-9
        Result.Result = Math.Pow(inputA, inputB);
        Result.IsSuccess = true;
        Result.Operation = $"{inputA} ^ {inputB}";
        Result.Error = null;
        return Result;
    }

    // Logarithm method. Catches when A <= 0 or B == 0
    public CalculatorResult Logarithm(double inputA, double inputB) {
        // preq-ENGINE-10
        Result.Operation = $"{inputA} log {inputB}";
        
        if (inputA <= 0) {
            Result.Result = 0;
            Result.Error = "Error: A cannot be equal to or less than 0";
            Result.IsSuccess = false;
            return Result;
        }
        
        if (inputB == 0) {
            Result.Result = 0;
            Result.Error = "Error: B cannot be equal to 0";
            Result.IsSuccess = false;
            return Result;
        }
        
        Result.Result = Math.Log(inputA, inputB);
        Result.IsSuccess = true;
        Result.Error = null;
        return Result;
    }

    // Root method. Catches if B == 0
    public CalculatorResult Root(double inputA, double inputB) {
        // preq-ENGINE-11
        Result.Operation = $"{inputA} root {inputB}";
        
        if (inputB == 0) {
            Result.Result = 0;
            Result.Error = "Error: B cannot be equal to 0";
            Result.IsSuccess = false;
            return Result;
        }
        
        Result.Result = Math.Pow(inputA, 1 / inputB);
        Result.IsSuccess = true;
        Result.Error = null;
        return Result;
    }

    // Factorial method. A == 0 will return 1.
    public CalculatorResult Factorial(double inputA) {
        // preq-ENGINE-12
        inputA = Math.Round(inputA); // Unneeded? Not sure if we need to worry about this.
        double factorial = 1;
        Result.Operation = $"{inputA}!";

        if (inputA == 0) {
            Result.Result = 1;
            Result.IsSuccess = true;
            Result.Error = "Convention!"; // Not a real error, just to show that this statement is being hit
            return Result;
        }
        
        for (int i = 1; i <= inputA; i++) {
            factorial *= i;
        }

        Result.Result = factorial;
        Result.IsSuccess = true;
        Result.Error = null;
        return Result;
    }

    public CalculatorResult Sine(double inputA) {
        // preq-ENGINE-13
        Result.Result = Math.Round(Math.Sin(inputA * Math.PI / 180)); // Is this really how I'm supposed to do this??
        Result.IsSuccess = true;
        Result.Operation = $"sin({inputA})";
        Result.Error = null;
        return Result;
    }

    public CalculatorResult Cosine(double inputA) {
        // preq-ENGINE-14
        Result.Result = Math.Round(Math.Cos(inputA * Math.PI / 180)); // Is this really how I'm supposed to do this??
        Result.IsSuccess = true;
        Result.Operation = $"cos({inputA})";
        Result.Error = null;
        return Result;
    }

    public CalculatorResult Tangent(double inputA) {
        // preq-ENGINE-15
        Result.Result = Math.Round(Math.Tan(inputA * Math.PI / 180)); // Is this really how I'm supposed to do this??
        Result.IsSuccess = true;
        Result.Operation = $"tan({inputA})";
        Result.Error = null;
        return Result;
    }

    // Reciprocal method. Catches if A == 0
    public CalculatorResult Reciprocal(double inputA) {
        // preq-ENGINE-16
        Result.Operation = $"1 / {inputA}";
        
        if (inputA == 0)
        {
            Result.Result = 0;
            Result.IsSuccess = false;
            Result.Error = "Error: A cannot be 0";
            return Result;
        }
        
        Result.Result = 1 / inputA;
        Result.IsSuccess = true;
        Result.Error = null;
        return Result;
    }
}