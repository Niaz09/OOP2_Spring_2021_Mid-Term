using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[5];

            Console.Write("Array 1: ");
            for(int i = 0; i < arr1.Length; i++) 
            {
                Console.Write("\t");
                Console.Write(arr1[i]);
            }
            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.Write("\nArray 2: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("\t");
                Console.Write(arr2[i]);
            }
        }
        

    }
}
