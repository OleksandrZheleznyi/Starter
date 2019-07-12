using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter N array size: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] array = new int[N];

            Random rand = new Random();

            for (int i = 0; i < N; ++i)
            {
                array[i] = rand.Next(10);
                Console.Write("{0:G}, ", array[i]);
            }

            Console.WriteLine();

            MaxArray(array);
            MinArray(array);
            SumArray(array);
            AverageArray(array);
            OddArray(array);

            Console.WriteLine();
            //2
            int[] array2 = new int[] { 2, 3, 5, 1, 8, 0, 9 };
            foreach (int i in array2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            MyReverse(array2);

            Console.WriteLine("Reverse array");
            foreach (int i in array2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine();
            int[] array3 = SubArray(array2, 2, 7);
            foreach (int i in array3)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            //3
            Console.WriteLine();
            int[] array4 = new int[4] {1, 3, 4, 6};
            foreach (int i in array4)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Array length = {0:G}", array4.Length);

            PlusOne(ref array4);

            foreach (int i in array4)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Array length = {0:G}", array4.Length);

            Console.WriteLine();

            int[] array5 = new int[5] {2, 6, 7, 6, 1};
            foreach (int i in array5)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
           
            PlusOneValue(ref array5, 9);

            foreach (int i in array5)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("another way to output an array");
            Array.ForEach(array5, Console.Write);

            Console.WriteLine();
            Console.WriteLine();

            //5(additional task)
            int[] array6 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            for (int i = array6.Length - 1; i > 0; --i)
            {
                Console.Write("{0:G} ", array6[i]);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
       
        private static void MaxArray(int [] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine("Max in array {0:G}", max);
        }

        private static void MinArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            Console.WriteLine("Min in array {0:G}", min);
        }

        private static void SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements {0:G}", sum);
        }

        private static void AverageArray(int[] arr)
        {
            int average = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                average += arr[i];
            }
            average = average / arr.Length;
            Console.WriteLine("Average of array elements {0:G}", average);
        }

        private static void OddArray(int[] arr)
        {
            Console.WriteLine("Odd numbers from array:");
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 != 0)
                    Console.Write("{0:G} ", arr[i]);
            }
            Console.WriteLine();
        }
       

        private static void MyReverse(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size / 2; ++i)
            {
                int temp = arr[i];
                arr[i] = arr[size - i - 1];
                arr[size - i - 1] = temp;
            }
        }

        private static int[] SubArray(int[] arr, int index, int count)
        {
            int[] sub = new int[count];
            for (int i = 0; i < count; ++i)
            {
                if ((index + i) < arr.Length)
                    sub[i] = arr[index + i];
                else
                    sub[i] = 1;
            }   
            return sub;
        }

        private static void PlusOne(ref int[] arr)
        {
            Array.Resize(ref arr, arr.Length + 1);
        }

        private static void PlusOneValue(ref int[] arr, int value)
        {
            PlusOne(ref arr);

            int size = arr.Length;
            for (int i = 0; i < size - 1; ++i)
            {
                arr[size - i - 1] = arr[size - i - 2];
            }
            arr[0] = value;
        }
    }
}
