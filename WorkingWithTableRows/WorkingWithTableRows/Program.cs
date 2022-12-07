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
            Random random= new Random();
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
                    Console.Write(array[i,j] + " ");
                }

                Console.WriteLine(" ]");
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == lineForSumm)
                    {
                        summLine += array[i, j];
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == rowForProduct)
                    {
                        productOfNumberColumn *= array[i, rowForProduct]; 
                    }
                }
            }

            Console.WriteLine($"Сумма 2-й строки составляет - {summLine}, произведение первого столбца составляет - {productOfNumberColumn}");
            Console.ReadKey();
        }
    }
}
