using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6AManipulateArrays
{
    public class Interface
    {
        //User sets an array to work with
        public static void arrayChoice()
        {
            Console.WriteLine("Array A: 0, 2, 4, 6, 8, 10");
            Console.WriteLine("Array B: 1, 3, 5, 7, 9");
            Console.WriteLine("Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9");

            int[] inputArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] inputArrayB = { 1, 3, 5, 7, 9 };
            int[] inputArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.Write("\n\nChoose an array that you would like to work with: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "a" || userChoice == "A")
            {
                doStuff(inputArrayA);
            }
            else if (userChoice == "b" || userChoice == "B")
            {
                doStuff(inputArrayB);
            }
            else if (userChoice == "c" || userChoice == "C")
            {
                doStuff(inputArrayC);
            }
            else
            {
                Console.WriteLine("Please check your input.");
                arrayChoice();
            }
        }

        //Print out returned arrays
        static void doStuff(int[] input)
        {
            Console.WriteLine($"The number of elements in input array is: {ManipulateArray.CountArray(input)}");
            Console.WriteLine($"The sum of elements input array is: {ManipulateArray.SumArray(input)}");
            Console.WriteLine($"The average of input array is: {ManipulateArray.MeanArray(input)}");


            Console.Write("Reversed version of input array is: ");
            ManipulateArray.ReverseArray(input);

            Console.WriteLine();

            Console.Write("Sorted order of chosen array is: ");
            ManipulateArray.SortArray(input);

            Console.WriteLine();

            ManipulateArray.RotateArrayEntry(input);

        }

        public static void printArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
