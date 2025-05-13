using System.Collections;
using NewCalculator.Operators;

class Program
{
  static void Main ()
  {
    Console.WriteLine("\t\tWelcome to your New Calculator!\n");
    //Console.WriteLine("Enter two numbers and one of the following operators: | + | - | * | / |");
    bool keepRunning = true;

    while (keepRunning)
    {
      Console.WriteLine("Enter you first number: ");
      double FirstNumber;
      while (!double.TryParse(Console.ReadLine(), out FirstNumber))
      {
        Console.WriteLine("Invalid input. Please enter a valid number");
      }

      Console.WriteLine("Enter you second number: ");
      double SecondNumber;
      while (!double.TryParse(Console.ReadLine(), out SecondNumber))
      {
        Console.WriteLine("Invalid input. Please enter a valid number");
      }

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

      Console.WriteLine($"\n{FirstNumber} {Operator} {SecondNumber} = {result}\n");
      Console.WriteLine("\nWould you like to do another operation?\n\n YES/NO\n ");
      string? Answer = Console.ReadLine();

      if (Answer?.ToLower() == "no" )
      {
        keepRunning = false;
      }
    }
  }
}