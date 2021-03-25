using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a string:");
        string message = Console.ReadLine();
        Console.WriteLine("Give an integer:");
        int intValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give a double:");
        double doubleValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Give a boolean:");
        bool truth = System.Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Your string: " + message);
        Console.WriteLine("Your integer: " + intValue);
        Console.WriteLine("Your double: " + doubleValue);
        Console.WriteLine("Your boolean: " + truth);
        Console.ReadKey();
    }
  }
}
