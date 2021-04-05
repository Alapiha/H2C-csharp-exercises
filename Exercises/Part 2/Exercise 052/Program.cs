using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        PrintFromNumberToOne(number);
        Console.ReadKey();
    }

    public static void PrintFromNumberToOne(int number)
    { 
        while (1 <= number)
        {
            Console.WriteLine(number);
            number--;
        }
        
    }
  }
}
