using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 4, 6, 8, 2, 5, 1, 3 };
            Sort(arr);

            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }

        static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1 ; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++) 
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
