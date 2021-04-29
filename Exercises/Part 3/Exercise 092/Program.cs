using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
        string name = "longest";   
        int l = 0;
        int x = 2020;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "")
            {
                break;
            }
            string[] parts = input.Split(',');
            
            int year = Convert.ToInt32(parts[1]);
            if (x > year)
            {
                x = year;       
            }
            if (l < parts[0].Length)
            {
                l = parts[0].Length;
                name = parts[0];
            }
        }
        
        Console.WriteLine("Longest name: " + name);
        Console.WriteLine("Highest age: " + (2020 - x));
        Console.ReadKey();
    }
  }
}



