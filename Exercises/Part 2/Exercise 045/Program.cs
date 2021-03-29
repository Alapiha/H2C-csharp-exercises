using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i <= number)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.ReadKey();
    }
  }
}
