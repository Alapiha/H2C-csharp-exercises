﻿using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        while (true)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == -1)
            {
                break;
            }
            list.Add(input);
        }
        Console.WriteLine("From where?");
        int fromWhere = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Where to?");
        int whereTo = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while (i < list.Count) 
        {
            if (fromWhere <= list[i])
            { 
                if (whereTo >= list[i])
                {
                    Console.WriteLine(list[i]);
                }
            }
            i++;
        } 
        Console.ReadKey();
    }
  }
}
