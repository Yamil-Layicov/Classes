using System;

namespace Task1Classs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = RandomArray();
            Console.WriteLine("Unsorted array:  \n");
            PrintArray(arr);
            Console.WriteLine("Sorted array : \n");
            arr = CustomSort(arr);

            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }
        static int[] RandomArray()
        {

            Console.Write("Arrayin size-ni daxil edin - ");
            int.TryParse(Console.ReadLine(), out int size);
            Console.WriteLine();

            int[] arr = new int[size];
            Random randInt = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randInt.Next(100);
            }

            return arr;
        }
        static int[] CustomSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
