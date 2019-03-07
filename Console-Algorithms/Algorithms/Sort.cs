using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms.Algorithms
{
    public class Sort
    {
        public T[] Exchange<T>(T[] data, int first, int second)
        {
            T temporary;

            temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;

            return data;
        }

        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    this.QuickSort(arr, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    this.QuickSort(arr, pivot + 1, right);
                }
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

            }
        }

        public int[] BubbleSort(int[] arr)
        {
            int temp;

            // run this based on array length amount
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // go through each array value
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    // check if left array is greater than right array
                    if (arr[j] > arr[j + 1])
                    {
                        // exchange between the arrays if left is greater than right
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
