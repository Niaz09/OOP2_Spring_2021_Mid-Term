using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 2, 2, 106, 43, 2 };
            int i, j;

            Console.Write("Array: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("\t");
                Console.Write(arr[i]);
            }
            Console.Write("\nArray with unique elements: ");
            for(i = 0; i < arr.Length; i++)
            {
                for(j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.Write("\t");
                    Console.Write(arr[i]);
                }
            }

        }
    }
}
