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
            ////Loops
            ////For loops iterate through conditions and runs the loop until the condition is not valid
            ////Examples:
            ////Initialize arrays
            //int[] original = new int [10];
            //for (int i = 0; i < 10; i++)
            //    original[i] = i * 3;
            //int[] copy = new int[original.Length];
            ////As long as variable i is less than the length of array original
            ////increment by 1
            //for (int i = 0; i < original.Length; i++)
            ////as each loop progresses make copy element i equals original element i
            //    copy[i] = original[i];
            ////Print each element for each array
            //for (int i = 0; i < original.Length; i++)
            //    Console.WriteLine(original[i] + "\t" + copy[i]);
            //for (int i = 50; i <= 100; i++)
            //    Console.WriteLine(i);


            //string greeting = "My name is Little Bill.";
            ////The .Split method splits the string at spaces and adds each word as an element of an array
            //string[] wordsInGreeting = greeting.Split();
            //for (int index = 0; index < wordsInGreeting.Length; index++)
            //    Console.WriteLine(wordsInGreeting[index]);

            //Create an array called days with the elements Monday, Tuesday, Wednesday.
            //Using a For loop print each elements of the array days.

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //    Console.WriteLine(days[i]);

            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in
            //the array and using a For Loop, print each word
            //string story = "Once upon a time";
            //string [] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //    Console.WriteLine(storyWords[i]);


            ////Determine the product (multiplication) of 1 through 10 using a For Loop
            ////Print the product to the screen
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);
            ////Second Way
            //int productOne = 1;
            //for (int i = 1; i <=10; i++)
            //{
            //    productOne = productOne * i;
            //}
            //Console.WriteLine(productOne);


            //FOREACH loops
            //Used to iterate over a collection (ex. array or list)
            //You can think of the structure of a foreach loop as the statement:
            //
            //foreach(dataType variable in collectionName)
            //{
            //  Do something
            //}
            //
            //int [] studentGrades = {4,4,4,3,4,3};
            //foreach(int grade in studentGrades)
            //{
            //   Console.WriteLine(grade)
            //}
            //string[] calendar = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            //foreach(string month in calendar)
            //{
            //    Console.WriteLine(month);

            //string[] musicians = { "Nengo", "Arctic Monkeys", "Florence", "John Newman", "TDCC", "Elvis" };
            //foreach(string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}
            Console.WriteLine("Enter your name:");
            string firstName = Console.ReadLine();
            while(firstName.ToLower () == "jonathan" )
            {
                Console.WriteLine("Dude, you're amazing.");
                break;
            }
        }
    }
}
