using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
        // DO NOT CHANGE THE FOLLOWING CODE!
        int[] array = new int[10];
        array[0] = 6;
        array[1] = 2;
        array[2] = 8;
        array[3] = 1;
        array[4] = 3;
        array[5] = 0;
        array[6] = 9;
        array[7] = 7;

        Console.WriteLine("Search for?");
        int searching = Convert.ToInt32(Console.ReadLine());

      // Implement the search functionality here
        
        bool containsNumber = false;

        foreach (int n in array) // go over every number in the list
        {
            if (n == searching) // check if it matches
            {
                containsNumber = true;
                
                break; // no need to check any further
                
            }
        }
        if (containsNumber = true)
        { 
        
            for (int i = 0; i < array.Length; i++)
		    {
                if (array[i] == searching)
                {         
                    Console.WriteLine(searching + " is at index " + i);     
                }  
           
            }
        }
        else (containsNumber = false);
        {
            Console.WriteLine("not found");
        }
        Console.ReadKey();
		

    }

  }
}


