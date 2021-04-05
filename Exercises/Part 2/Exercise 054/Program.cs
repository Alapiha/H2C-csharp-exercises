using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        DivisibleByThreeInRange(num1, num2);
        Console.ReadKey();
    }

    public static void DivisibleByThreeInRange(int beginning, int end)
    {
        while (beginning <= end)
        {
            if (beginning % 3 == 0)
            {
                Console.WriteLine(beginning);  
            }
            beginning++;
        }
        
    }
  }
}
