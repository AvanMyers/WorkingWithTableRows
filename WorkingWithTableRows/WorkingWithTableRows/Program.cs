using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTableRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summSecondLine = 0;
            int productOfNumberFirstColumn = 1;
            int[,] array = {
                { 3, 4, 5, 9 },
                { 5, 1, 1, 5 },
                { 5, 8, 4, 21 } };


            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 1)
                    {
                        summSecondLine+= array[i, j];
                    }

                    if (j == 0)
                    {
                        productOfNumberFirstColumn *= array[i, 0];
                    }
                }
            }
            Console.WriteLine($"Сумма 2-й строки составляет - {summSecondLine}, произведение первого столбца составляет - {productOfNumberFirstColumn}");
            Console.ReadKey();
        }
    }
}
