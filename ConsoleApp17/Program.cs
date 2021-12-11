using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 8, 2, 5, 6, 48, 51,56,90 };
            for (int i = arr.Length - 1; i>=0 ; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
