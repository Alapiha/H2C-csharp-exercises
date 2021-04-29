using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
        
        int x = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "")
            {
                break;
            }
            string[] parts = input.Split(',');
            
            int age = Convert.ToInt32(parts[1]);
            if (x < age)
            {
                x = age;
            }

        }
        Console.WriteLine("Age of the oldest: " + x);
        Console.ReadKey();


    }
  }
}



