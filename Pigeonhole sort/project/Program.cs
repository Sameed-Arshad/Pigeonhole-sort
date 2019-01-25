using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            pigeonholesort pegonsort = new pigeonholesort();
            int[] arr = {8, 3, 2, 7, 4, 6, 8};
            int n = 7;
            Console.Write("Unsorted order is : ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " "); 
            pegonsort.pigeonhole_sort(arr,n);
            Console.Write("\nSorted order is : ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\n");
        }

    }
    class pigeonholesort
    {
        public void pigeonhole_sort(int[] arr,int n)
        {
            int min = arr[0];
            int max = arr[0];
            int range, i, j, index;
            //working for the containers for the objects
            for (int a = 0; a < n; a++)
            {
                if (arr[a] > max)
                    max = arr[a];//to find the maximum element in the array for the range
                if (arr[a] < min)
                    min = arr[a];//to find the minimum element in the array for the range 
            }
            range = max - min + 1;   //to determine the containers to store the objects

            
            int[] containers = new int[range];
            for (i = 0; i < n; i++)
                containers[i] = 0;

            //to determine the key values for the elements of the array
            for (i = 0; i < n; i++)
                containers[arr[i] - min]++;      //key values = arr[i]-min
            
            //index is zero beacuse we have to initialize again for another element of the unsorted array
            index = 0;
            for (j = 0; j < range; j++)
            {
                while (containers[j]-- > 0) //containers[j]-- = containers[j]-1;
                { arr[index++] = j + min; }
            }

        }
    }
}
