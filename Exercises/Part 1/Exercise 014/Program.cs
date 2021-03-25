using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me the truth!");
        bool truth = System.Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine(truth);
        Console.ReadKey();
    }
  }
}
