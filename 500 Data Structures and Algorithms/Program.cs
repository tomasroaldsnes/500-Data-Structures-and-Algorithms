using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500_Data_Structures_and_Algorithms
{
    class Program
    {
        //find a given sum in an unsorted array 
        static void findGivenSum(int[] arr, int n, int sum)
        {
            //array with order by descending
           arr = arr.OrderByDescending(c => -c).ToArray();

            //mantain to indexes for the endpoints of the array
            int low = 0;
            int high = n-1;

            //reduce searchspace with each iteration 
            while(low < high)
            {
                Console.WriteLine(arr[low] + " | " + arr[high]);
                if(arr[low] + arr[high] == sum)
                {
                    Console.WriteLine("Pair found!");
                    Console.WriteLine("The numbers that match up are: " + arr[low] + "  " + arr[high]);
                    return;
                }
                //increment low if lower than sum or decrement higher if over
                if (arr[low] + arr[high] < sum) low++;
                else if (arr[low] + arr[high] > sum) high--;
            }
            Console.WriteLine("Could not find a match");

        }
        
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 2, 5, 3, 6 , 4 ,6 ,3, 1 ,33,5,2,665,4,9, 7};
            int sum = 10;

            int n = arr.Length;
            Console.WriteLine("hello world!");

            findGivenSum(arr, n, sum);
            Console.ReadLine();
        }
    }
}
