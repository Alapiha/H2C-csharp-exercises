using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(number, 2));
        Console.ReadKey();

    }
  }
}
