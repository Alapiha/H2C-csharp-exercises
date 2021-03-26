using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        { 
            Console.WriteLine("You're underage!");    
        }
        else
        { 
            Console.WriteLine("You're an adult!");    
        }
        Console.ReadKey();

    }
  }
}
