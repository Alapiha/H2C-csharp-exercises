using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
        int sum = 0;
        while (true) 
        {
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) 
            {
                break;
            } 
            if (number < 0)
            {
                    sum = sum + 1;
            }
        }
        Console.WriteLine("Total amount of negative numbers: " + sum);
        Console.ReadKey();

    }
  }
}
