using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine(number * -1);
        }
        else
        {
            Console.WriteLine(number);
        }
        Console.ReadKey();
    }
  }
}
