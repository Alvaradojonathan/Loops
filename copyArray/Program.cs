using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops
            //For loops iterate through conditions and runs the loop until the condition is not valid
            //Examples:
            //Initialize arrays
            int[] original = new int [10];
            for (int i = 0; i < 10; i++)
                original[i] = i * 3;
            int[] copy = new int[original.Length];
            //As long as variable i is less than the length of array original
            //increment by 1
            for (int i = 0; i < original.Length; i++)
            //as each loop progresses make copy element i equals original element i
                copy[i] = original[i];
            //Print each element for each array
            for (int i = 0; i < original.Length; i++)
                Console.WriteLine(original[i] + "\t" + copy[i]);
            for (int i = 50; i <= 100; i++)
                Console.WriteLine(i);
        }
    }
}
