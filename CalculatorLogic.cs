class CalculatorLogic
{
   public double Add(double inputA, double inputB)
   {
      return (inputA + inputB);
   }

   public double Subtraction(double inputA, double inputB)
   {
      return (inputA - inputB);
   }

   public double Multiplication(double inputA, double inputB)
   {
      return (inputA * inputB);
   }

   public double Division(double inputA, double inputB)
   {
      return (inputA / inputB);
   }

   public int Equals(double inputA, double inputB)
   {
      if (Math.Round(inputA, 8) == Math.Round(inputB, 8))
      {
         return 1;
      }
      else
      {
         return 0;
      }
   }

   public double Power(double inputA, double inputB)
   {
      return Math.Pow(inputA, inputB);
   }

   public double Logarithm(double inputA, double inputB)
   {
      return Math.Log(inputA, inputB);
   }

   public double Root(double inputA, double inputB)
   {
      return Math.Pow(inputA, (1 / inputB));
   }

   public double Factorial(double inputA)
   {
      inputA = Math.Round(inputA);
      double fact = 1;
      for (int i = 1; fact < inputA; i++)
      {
         fact *= i;
      }

      return fact;
   }

   public double Sine(double inputA)
   {
      return Math.Sin(inputA);
   }

   public double Cosine(double inputA)
   {
      return Math.Cos(inputA);
   }

   public double Tangent(double inputA)
   {
      return Math.Tan(inputA);
   }

   public double Reciprocal(double inputA)
   {
      return (1 / inputA);
   }

}