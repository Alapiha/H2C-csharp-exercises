﻿using System;

namespace exercise_11
{
    class Program
    {
        public static void Main(string[] args)
        {
            int dayCount = 100;
            double hoursToLunch = 1;
            string statement = "Are you sure?";
            dayCount = 200;
            hoursToLunch = 3.5;
            statement = "It sure is!";

            // DO NOT TOUCH THESE!
            Console.WriteLine("Days to summer:");
            Console.WriteLine(dayCount);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hoursToLunch);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(statement);

            Console.ReadKey();
        }
    }
}
