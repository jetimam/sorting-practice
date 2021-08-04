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
                                                 "\n1. Bubble Sort | 2. Insertion Sort | 3. Selection Sort | 4. Quick Sort");

                switch (sortAlgorithm)
                {
                    case 1:
                        ArrayPrint(BubbleSort(arr));
                        
                        break;
                    
                    case 2:
                        ArrayPrint(InsertionSort(arr));
                        
                        break;
                    
                    case 3:
                        ArrayPrint(SelectionSort(arr));
                        
                        break;
                    
                    case 4:
                        QuickSort(arr, 0, arr.Length - 1);
                        ArrayPrint(arr);
                        
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

        static void QuickSort(int[] arr, int min, int max)
        {
            if (min < max)
            {
                int pivot = QuickSortPivot(arr, min, max);
                
                QuickSort(arr, min, pivot - 1);
                QuickSort(arr, pivot + 1, max);
            }
        }

        static int QuickSortPivot(int[] arr, int min, int max)
        {
            int pivot = arr[max];
            int temp;
            int i = min - 1;

            for (int j = min; j < max; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
            
            temp = arr[i + 1];
            arr[i + 1] = arr[max];
            arr[max] = temp;

            return i + 1;
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

        static void ArrayPrint(int[] arr)
        {
            string str = "";
            foreach (int ele in arr)
            {
                str += ele + ", ";
            }
            
            Console.WriteLine(str.Remove(str.Length - 2));
        }
    }
}