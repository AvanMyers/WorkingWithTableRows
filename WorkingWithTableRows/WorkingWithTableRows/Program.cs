using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTableRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 3;
            int arrayDeep = 5;
            int minRandom = 1;
            int maxRandom = 10;
            int lineForSumm = 1;
            int rowForProduct = 0;
            int summLine = 0;
            int productOfNumberColumn = 1;
            int[,] array = new int[arraySize, arrayDeep];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("[ ");

                for (int j = 0; j < arrayDeep; j++)
                {
                    array[i, j] = random.Next(minRandom, maxRandom);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine(" ]");
            }

            for (int i = 0; i < arrayDeep; i++)
            {
                summLine += array[lineForSumm, i];
            }

            for (int i = 0; i < arraySize; i++)
            {
                productOfNumberColumn *= array[i, rowForProduct];
            }


            Console.WriteLine($"Сумма {lineForSumm + 1} строки составляет - {summLine}, произведение {rowForProduct + 1} столбца составляет - {productOfNumberColumn}");
            Console.ReadKey();
        }
    }
}
