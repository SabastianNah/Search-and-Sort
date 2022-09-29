using System;

namespace MajorCodingAssignment4
{
    class SearchNSort
    {
        public static void BubbleSort(int[] array)
        {
            int placeHolder;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        placeHolder = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = placeHolder;
                    }
                }
            }
        }
        public static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int next = array[i];
                int past = i - 1;
                while (past >= 0 && array[past] > next)
                {
                    array[past + 1] = array[past];
                    past = past - 1;
                }
                array[past + 1] = next;
            }
        }
        public static void JumpSearch(int[] array, int find)
        {
            int size = array.Length;
            int index = 0;
            int next = (int)Math.Floor(Math.Sqrt(size));
            Boolean found = false;
            int past = 0;
            while (array[Math.Min(next, size) - 1] < find)
            {
                past = next;
                next += (int)Math.Floor(Math.Sqrt(size));
                if (past >= size)
                {
                    found = false;
                }
            }
            while (array[past] < find)
            {
                past++;
                if (past == Math.Min(next, size))
                    found = false;
            }
            if (array[past] == find)
            {
                found = true;
                index = past;
            }
            if (found != true)
            {
                Console.WriteLine("\nThe element you are looking for is not in this list.");
            }
            else
            {
                Console.WriteLine("\nThe element you are looking for is at index " + index + ".");
            }
        }
        public static void BinarySearch(int[] array, int find)
        {
            Boolean found = false;
            int index = 0;
            int min = 0;
            int max = array.Length - 1;
            while (found == false)
            {
                int mid = (min + max) / 2;
                if (array[mid] == find)
                {
                    index = mid;
                    found = true;
                }
                else if (array[mid] > find)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (found != true)
            {
                Console.WriteLine("\nThe element you are looking for is not in this list.");
            }
            else
            {
                Console.WriteLine("\nThe element you are looking for is at index " + index + ".");
            }
        }
        public static void LinearSearch(int[] array, int find)
        {
            Boolean found = false;
            int index = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] == find)
                {
                    found = true;
                    index = i;
                }
            }
            if (found == true)
            {
                Console.WriteLine("\nThe element you are looking for is at index " + index + ".");
            }
            else
            {
                Console.WriteLine("\nThe element you are looking for is not in this list.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to My Searching and Sorting Algorith!\n\nWhat search/sort method would you like to do?");
            String responseToMethod = Console.ReadLine();
            Console.Write("\nHow many numbers do you have?");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Please enter a number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //which sort method

            if (responseToMethod.ToLower() == "bubble sort")
            {
                BubbleSort(array);
                Console.WriteLine("Sorted:");
                foreach (int num in array)
                    Console.Write(num + " ");
            }
            else if (responseToMethod.ToLower() == "insertion sort")
            {
                InsertionSort(array);
                Console.WriteLine("Sorted:");
                foreach (int num in array)
                    Console.Write(num + " ");
            }
            else
            {
                Console.Write("\nWhat number are you looking for?");
                int find = Convert.ToInt32(Console.ReadLine());
                if (responseToMethod.ToLower() == "binary search")
                {
                    BubbleSort(array);
                    BinarySearch(array, find);
                }
                if (responseToMethod.ToLower() == "linear search")
                {
                    BubbleSort(array);
                    LinearSearch(array, find);
                }
                if (responseToMethod.ToLower() == "jump search")
                {
                    BubbleSort(array);
                    JumpSearch(array, find);
                }
            }
        }
    }
}
