using System.Collections;
using NewCalculator.Operators;

class Program
{
  static void Main ()
  {
    Console.WriteLine("Welcome to your New Calculator!");
    //Console.WriteLine("Enter two numbers and one of the following operators: | + | - | * | / |");
    Console.WriteLine("Enter you first number: ");
    string? FirstInput = Console.ReadLine();
    double FirstNumber = double.Parse(FirstInput);

    Console.WriteLine("Enter you second number: ");
    string SecondInput = Console.ReadLine();
    double SecondNumber = double.Parse(SecondInput);

    Console.WriteLine("Enter a operator: ");
    string? Operator = Console.ReadLine();

    double result = 0;
    switch (Operator)
    {
      case "+":
      result = Add.Addition(FirstNumber, SecondNumber);
      break;

      case "-":
      result = Subtract.Subtraction(FirstNumber, SecondNumber);
      break;

      case "*":
      result = Multiply.Multiplication(FirstNumber, SecondNumber);
      break;

      case "/":
      result = Divide.Division(FirstNumber, SecondNumber);
      break;
    }

    Console.WriteLine($"{FirstNumber} {Operator} {SecondNumber} = {result}");
  }
}