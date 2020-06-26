using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 10, 3, 1, 6, 2 };
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] array = { 3, 0, 2, 5, -1, 4, 1 };

            // Flag that will signal that the array is sorted.
            bool isSorted = true;

            Console.WriteLine("Original array :");

            // Write out the original array.
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            // Loop through each element in the array.
            for (int i = 0; i < array.Length; i++)
            {
                // Loop through each element of the array and compare the values of the current
                // position in the array with the next highest position in the array.
                // ----------------------------------------------------------------------------
                // Each loop that we work through will decrease the array length by one as the
                // highest value will be swapped over to the last position in the array.  Once
                // it is in place, we don't need to check it again.
                for (int j = 0; j < (array.Length - (i + 1)); j++)
                {
                    // Assume the array is sorted.
                    isSorted = true;

                    // Compare the current postion in the array to the next highest position.
                    if (array[j] > array[j + 1])
                    {
                        // The postion to the left is higher, swap the values.
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        // The array wasn't sorted since we had to swap values.  Set the flag
                        // to false.
                        isSorted = false;
                    }
                }

                // If the array is sorted, then we can break out of the sorting loops.
                if (isSorted)
                {
                    break;
                }
            }

            Console.WriteLine("\n" + "Sorted array :");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n");
        }
    }
}