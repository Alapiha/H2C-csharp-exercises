using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        while (number <= 100)
        {
            Console.WriteLine(number);
            number++;
        }
        Console.ReadKey();

    }
  }
}
