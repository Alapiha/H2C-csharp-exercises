﻿using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 1984)
        { 
            Console.WriteLine("Orwell");    
        }
        Console.ReadKey();

    }
  }
}
