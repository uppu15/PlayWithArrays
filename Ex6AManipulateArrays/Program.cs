using System;

namespace Ex6AManipulateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 6A : Manipulating Arrays");

            arrayChoice();
        }

        static void doStuff(int[] input)
        {
            Console.WriteLine($"The number of elements in input array is: {CountArray(input)}");
            Console.WriteLine($"The sum of elements input array is: {SumArray(input)}");
            Console.WriteLine($"The average of input array is: {MeanArray(input)}");


            Console.Write("Reversed version of input array is: ");
            ReverseArray(input);

            Console.WriteLine();

            Console.Write("Sorted order of chosen array is: ");
            SortArray(input);

            Console.WriteLine();
            RotateArrayEntry(input);
        }

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

        public static int CountArray(int[] input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                count++;
            }
            return count;
        }

        public static int SumArray(int[] input)
        {
            int sum = 0;
            int[] array = input;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static double MeanArray(int[] input)
        {
            double mean = 0;
            int i;
            double sum = 0;
            int[] array = input;
            for (i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            mean = sum / i;

            return mean;
        }

        public static int[] ReverseArray(int[] foward)
        {
            int[] backward = new int[foward.Length];
            for (int i = 0; i < foward.Length; i++)
            {
                backward[i] += foward[foward.Length - (i + 1)];
            }

            printArray(backward);
            return backward;
        }

        public static void RotateArrayEntry(int[] input)
        {
            try
            {
                Console.Write("Which way would you like to rotate?:  ");
                string entryArray = Console.ReadLine();
                Console.Write("How many times would you like to rotate?:  ");
                int numRotation = int.Parse(Console.ReadLine());

                if (entryArray == "left")
                {
                    RotateLeftArray(input, numRotation);
                }
                else if (entryArray == "right")
                {
                    RotateRightArray(input, numRotation);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please check your input.");
                RotateArrayEntry(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please check your input.");
                RotateArrayEntry(input);
            }
        }

        public static int[] RotateRightArray(int[] input, int numRoatate)
        {
            for (int i = 0; i < numRoatate; i++)
            {
                int fromEndToFirst = input[input.Length - 1];

                //Rotate Right
                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = fromEndToFirst;
            }
            printArray(input);
            return input;
        }

        public static int[] RotateLeftArray(int[] input, int numRotate)
        {
            for (int i = 0; i < numRotate; i++)
            {
                int fromFirstToEnd = input[0];

                //Rotate left
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = fromFirstToEnd;
            }
            printArray(input);
            return input;
        }

        static void printArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }

        public static int[] SortArray(int[] unsortedArray)
        {
            int[] onhand = new int[unsortedArray.Length];

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                onhand[i] = unsortedArray[i];
            }

            int[] sortedArray = new int[onhand.Length];

            for (int j = 0; j < onhand.Length; j++)
            {
                for (int i = 0; i < onhand.Length; i++)
                {
                    if ((i + 1) < onhand.Length && onhand[i] > onhand[i + 1])
                    {
                        int placeHolder = onhand[i];
                        onhand[i] = onhand[i + 1];
                        onhand[i + 1] = placeHolder;
                    }
                    sortedArray[i] = onhand[i];
                }
            }
            printArray(sortedArray);
            return sortedArray;
        }
    }
}
