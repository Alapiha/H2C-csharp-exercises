﻿using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true)
        { 
            string text = Console.ReadLine();
            if (text == "")
            {
                break;
            }
            string[] pieces = text.Split(' ');
            Console.WriteLine(pieces[pieces.Length - 1]);
        }
        Console.ReadKey();

    }
  }
}



