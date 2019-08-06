using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6AManipulateArrays
{
    public class ManipulateArray
    {
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

            Interface.printArray(backward);
            return backward;
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
            Console.WriteLine();
            Interface.printArray(input);
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
            Interface.printArray(input);
            return input;
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
            Interface.printArray(sortedArray);
            return sortedArray;
        }
    }
}
