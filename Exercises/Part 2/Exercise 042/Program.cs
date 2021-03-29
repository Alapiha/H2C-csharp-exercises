using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first number:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number:");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(first + second));
        Console.ReadKey();
    
    }
  }
}
