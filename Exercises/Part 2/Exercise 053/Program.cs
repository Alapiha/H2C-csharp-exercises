using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        Division(num1,num2);
        Console.ReadKey();

    }

    public static void Division(int numerator, int denominator)
    {
        Console.WriteLine((double)numerator / denominator); 
    }
  }
}
