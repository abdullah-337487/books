using System;
using System.Numerics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pick();
        }
        static void pick()
        {
            int[] arr = { 10, 12, 4, 5, 9 };
            int result1 = 0;
           
            for(int i = arr.Length - 1; i >= 0; i--)
    {
                for (int j = 0; j < arr.Length; j++)
                {

                    int indexi = i;
                    int indexj = j;
                    if ( indexi == 0 && indexj == 0 || arr[i] == arr[j])
                    {
                        result1 = 0;
                        break;
                    }
                    
                    else
                    {
                        result1 = arr[i] - arr[j];
                    }
                    
                    if (result1 > 0)
                    {
                        Console.WriteLine(result1);
                    }
                }

            }
        }
    }
}