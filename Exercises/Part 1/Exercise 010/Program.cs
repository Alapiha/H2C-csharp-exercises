﻿using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();
            Console.WriteLine("Here is the story:\n" +
            "Once upon a time there was a " + profession + " called " + name + ".\n" +
            "On her way to work, " + name + " often pondered what being a " + profession + " meant to them.\n" +
            "When you work as a " + profession + " you meet interesting people.\n" +
            name + " enjoys their work as a " + profession + ", the end.");
            Console.ReadKey();
        }
    }
}
