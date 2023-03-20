using System;

namespace NestedForLoop2DArray.Net5._0
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }
        }
    }
}
