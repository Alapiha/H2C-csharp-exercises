using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
        int amount = 0; 
        int sum = 0;
        while (true) 
        {
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) 
            {
                break;
            } 
            if (number != 0)
            {
                sum = sum + number;
                amount = amount + 1;
            }
        }
        Console.WriteLine("Total sum of numbers: " + sum);
        Console.WriteLine("Total amount of numbers: " + amount);
        Console.ReadKey();
      
    }
  }
}
