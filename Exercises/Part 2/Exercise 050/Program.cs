using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("How many times?");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintPhrase(number);
        Console.ReadKey();
 
    }

    // Write your method here:
    public static void PrintPhrase(int number) 
    {
        int i = 0;
        while (i < number)
        {
            Console.WriteLine("In a hole in the ground there lived a method");
            i++;
        }
        
    }
  }
}
