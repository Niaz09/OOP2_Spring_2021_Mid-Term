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
            int[] arr2 = new int[] { 1, 2, 100, 100, 106, 1, 2 };
            int count = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] == arr2[j])
                    {
                        count++;
                        break;

                    }

                }
            }
            Console.WriteLine("Total Number of duplicate elements: {0}", count);
        }
    }
}
