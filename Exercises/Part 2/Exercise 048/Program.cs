using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
        double sum = 0;
        int amount = 0;
        double average = 0;
        int even = 0;
        int odd = 0;

        while (true) 
        {
            Console.WriteLine("Write numbers:");
            int number = Convert.ToInt32(Console.ReadLine());
 
            if (number == -1)
            {  
                break;
            }
            else
            {
                sum = sum + number; 
                amount++;
                average = sum / amount;
                
                if ((number % 2) == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
        }
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Numbers: " + amount);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
        Console.ReadKey();
 
    }
  }
}
