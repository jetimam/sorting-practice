using System;

namespace sorting_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sampleSize, sortAlgorithm;
            int[] arr;
            
            while (true)
            {
                sampleSize = Utility.IntInput("Please enter the size of the array you wish to sort.");

                arr = ArrayInitializer(sampleSize);

                sortAlgorithm = Utility.IntInput("Please enter which sorting algorithm you would like to use." +
                                                 "\n1. Bubble Sort | 2. Insertion Sort | 3. Selection Sort");

                switch (sortAlgorithm)
                {
                    case 1:
                        foreach (int ele in BubbleSort(arr))
                        {
                            Console.Write(ele + ", ");
                        }
                        
                        Console.WriteLine();
                        break;
                    
                    case 2:
                        foreach (int ele in InsertionSort(arr))
                        {
                            Console.Write(ele + ", ");
                        }
                        
                        Console.WriteLine();
                        break;
                    
                    case 3:
                        foreach (int ele in SelectionSort(arr))
                        {
                            Console.Write(ele + ", ");
                        }
                        
                        Console.WriteLine();
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;
                }
            }
        }

        static int[] BubbleSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
            return arr;
        }

        static int[] InsertionSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0 && arr[j] < arr[j - 1])
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }

            return arr;
        }

        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int tempIndex = 0;
                int tempValue = Int32.MaxValue;
                
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < tempValue)
                    {
                        tempValue = arr[j];
                        tempIndex = j;
                    }
                }
                arr[tempIndex] = arr[i];
                arr[i] = tempValue;

            }
            return arr;
        }
        
        static int[] ArrayInitializer(int size)
        {
            Random rand = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(size);
            }

            return arr;
        }
    }
}