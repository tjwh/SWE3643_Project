using Calculator;

namespace CalculatorUnitTests;

public class Tests {
    private CalculatorEngine _sut;

    [SetUp]
    public void Setup() {
        _sut = new CalculatorEngine();
    }

    [Test]
    public void Calculator_Addition_ShouldReturnSumOfTwoFloatingPointValues() {
        // preq-UNIT-TEST-2
        // Arrange
        double a = 5.5;
        double b = -3.15;
        double expectedResult = 2.35;

        // Act
        CalculatorResult result = _sut.Add(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Subtraction_ShouldReturnDifferenceOfTwoFloatingPointValues() {
        // preq-UNIT-TEST-3
        // Arrange
        double a = 27.93;
        double b = 4;
        double expectedResult = 23.93;

        // Act
        CalculatorResult result = _sut.Subtraction(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Multiplication_ShouldReturnProductOfTwoFloatingPointValues() {
        // preq-UNIT-TEST-4
        // Arrange
        double a = 5;
        double b = 7.1;
        double expectedResult = 35.5;

        // Act
        CalculatorResult result = _sut.Multiplication(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Division_ShouldReturnQuotientOfTwoFloatingPointValues() {
        // preq-UNIT-TEST-5
        // Arrange
        double a = 3.0;
        double b = 9.0;
        double expectedResult = 0.33333333333333331; // Jeff gave 0.33333333 as an answer, do we need to round?

        // Act
        CalculatorResult result = _sut.Division(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Division_ShouldReturnErrorsWhenDividingBy0() {
        // preq-UNIT-TEST-6
        // Arrange
        double a = 3.0;
        double b = 0.0;
        double expectedResult = 0; // Since I have it returning 0 right now for all fails.

        // Act
        CalculatorResult result = _sut.Division(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult)); // Checks for our 0 return
            Assert.That(result.Error, !Is.EqualTo(null)); // Checks to see if the err string is anything
            Assert.That(result.IsSuccess, Is.False); // Checks to make sure success is false
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | {result.Error} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Equals_ShouldReturn1WhenTwoValuesEqualEachotherWithin8DigitTolerance() {
        // preq-UNIT-TEST-7
        // Arrange
        double a = 0.333333331;
        double b = 0.333333332;
        double expectedResult = 1;

        // Act
        CalculatorResult result = _sut.Equals(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Equals_ShouldReturn0WhenTwoValuesDontEqualEachotherWithin8DigitTolerance() {
        // preq-UNIT-TEST-7 .... Still technically 7, keeping this as 7 OK?
        // Arrange
        double a = 0.33333333;
        double b = 0.33333334;
        double expectedResult = 0;

        // Act
        CalculatorResult result = _sut.Equals(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Power_ShouldReturnPowerOfTwoFloatingPointValues() {
        // preq-UNIT-TEST-8
        // Arrange
        double a = 2;
        double b = 3;
        double expectedResult = 8;

        // Act
        CalculatorResult result = _sut.Power(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Logarithm_ShouldReturnLogarithmOfTwoFloatingPointValues() {
        // preq-UNIT-TEST-9
        // Arrange
        double a = 8;
        double b = 2;
        double expectedResult = 3;

        // Act
        CalculatorResult result = _sut.Logarithm(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Logarithm_ShouldReturnErrorsWhenInputLessThanOrEqualTo0() {
        // preq-UNIT-TEST-10
        // Arrange
        double a = 0;
        double b = 2;
        double expectedResult = 0; // Since I have it returning 0 right now for all fails.

        // Act
        CalculatorResult result = _sut.Logarithm(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult)); // Checks for our 0 return
            Assert.That(result.Error, !Is.EqualTo(null)); // Checks to see if the err string is anything
            Assert.That(result.IsSuccess, Is.False); // Checks to make sure success is false
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | {result.Error} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Logarithm_ShouldReturnErrorsWhenNewBaseIs0() {
        // preq-UNIT-TEST-11
        // Arrange
        double a = 8;
        double b = 0;
        double expectedResult = 0; // Since I have it returning 0 right now for all fails.

        // Act
        CalculatorResult result = _sut.Logarithm(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult)); // Checks for our 0 return
            Assert.That(result.Error, !Is.EqualTo(null)); // Checks to see if the err string is anything
            Assert.That(result.IsSuccess, Is.False); // Checks to make sure success is false
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | {result.Error} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Root_ShouldReturnBthRootOfAFloatingPointValues() {
        // preq-UNIT-TEST-12
        // Arrange
        double a = 25;
        double b = 2;
        double expectedResult = 5;

        // Act
        CalculatorResult result = _sut.Root(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Root_ShouldReturnErrorsWhenRootValueIs0() {
        // preq-UNIT-TEST-13
        // Arrange
        double a = 8;
        double b = 0;
        double expectedResult = 0; // Since I have it returning 0 right now for all fails.

        // Act
        CalculatorResult result = _sut.Root(a, b);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult)); // Checks for our 0 return
            Assert.That(result.Error, !Is.EqualTo(null)); // Checks to see if the err string is anything
            Assert.That(result.IsSuccess, Is.False); // Checks to make sure success is false
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | {result.Error} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Factorial_ShouldReturnFactorialOfFloatingPointValue() {
        // preq-UNIT-TEST-14
        // Arrange
        double a = 5;
        double expectedResult = 120;

        // Act
        CalculatorResult result = _sut.Factorial(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Factorial_ShouldReturn1WhenInputIs0() {
        // preq-UNIT-TEST-15
        // Arrange
        double a = 0;
        double expectedResult = 1;

        // Act
        CalculatorResult result = _sut.Factorial(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo("Convention!")); // Checks to see if the err string is our special string
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Sine_ShouldReturnSineOfFloatingPointValue() {
        // preq-UNIT-TEST-16
        // Arrange
        double a = 360;
        double expectedResult = 0;

        // Act
        CalculatorResult result = _sut.Sine(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Cosine_ShouldReturnCosineOfFloatingPointValue() {
        // preq-UNIT-TEST-17
        // Arrange
        double a = 360;
        double expectedResult = 1;

        // Act
        CalculatorResult result = _sut.Cosine(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Tangent_ShouldReturnTangentOfFloatingPointValue() {
        // preq-UNIT-TEST-18
        // Arrange
        double a = 360;
        double expectedResult = 0;

        // Act
        CalculatorResult result = _sut.Tangent(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Reciprocal_ShouldReturnReciprocalOfFloatingPointValue() {
        // preq-UNIT-TEST-19
        // Arrange
        double a = 8;
        double expectedResult = 0.125;

        // Act
        CalculatorResult result = _sut.Reciprocal(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult));
            Assert.That(result.Error, Is.EqualTo(null)); // Checks to see if the err string is null
            Assert.That(result.IsSuccess, Is.True); // Checks to make sure success is true
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | Operation Success: {result.IsSuccess}");
    }
    
    [Test]
    public void Calculator_Reciprocal_ShouldReturnErrorsWhenDividingBy0() {
        // preq-UNIT-TEST-20
        // Arrange
        double a = 0;
        double expectedResult = 0; // Since I have it returning 0 right now for all fails.

        // Act
        CalculatorResult result = _sut.Reciprocal(a);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(expectedResult)); // Checks for our 0 return
            Assert.That(result.Error, !Is.EqualTo(null)); // Checks to see if the err string is anything
            Assert.That(result.IsSuccess, Is.False); // Checks to make sure success is false
        });
        Assert.Pass($"{result.Operation} = {expectedResult} | {result.Error} | Operation Success: {result.IsSuccess}");
    }
}