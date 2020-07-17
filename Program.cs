using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise_Calculate_inOneMaxtrix matrixOb = new Exercise_Calculate_inOneMaxtrix();

            int[,] matrix = matrixOb.creRndMatrixArr(3);
            matrixOb.PrintMatrix(matrix);
            Console.WriteLine(matrixOb.SumOfEven(matrix));
        }
    }
}
