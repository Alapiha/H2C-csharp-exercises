﻿using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
        int[] array = { 5, 1, 3, 4, 2 };
        PrintArrayInStars(array);
        Console.ReadKey();
    }

    public static void PrintArrayInStars(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
		{
            for (int j = 1; j <= array[i]; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

        }

    }
  }
}

