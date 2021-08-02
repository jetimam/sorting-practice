using System;
using System.Diagnostics;

namespace sorting_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sampleSize = Utility.IntInput("Please enter the size of the array you wish to sort.");

            int[] arr = ArrayInitializer(sampleSize);
        }

        static int[] ArrayInitializer(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }

            return arr;
        }
    }
}