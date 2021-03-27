using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 42) 
            {
                break;
            }           
        }
        Console.ReadKey();

    }
  }
}
