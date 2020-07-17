using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Exercise_Calculate_inOneMaxtrix
    {
        public int[,] creRndMatrixArr(int sides)
        {
            int[,] SquareMatrix = new int[sides, sides];
            Random rnd = new Random();
            for (int i = 0; i < SquareMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SquareMatrix.GetLength(1); j++)
                {
                    SquareMatrix[i, j] = rnd.Next(10, 90);
                }
            }

            return SquareMatrix;
        }

        public int SumOfEven(int[,] Matrix)
        {
            int sum = 0;

            for (int i=0;i<Matrix.GetLength(0);i++)
            {
                for (int j=0;j<Matrix.GetLength(1);j++)
                {
                    if (Matrix[i,j]%2==0)
                    {
                        sum += Matrix[i, j];
                    }
                }
            }

            return sum;
        }

        public int SumOfMainDia(int[,] Matrix)
        {
            int sum = 0;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                sum += Matrix[i,i];
            }

            return sum;
        }

        public int SumOfFillerDia(int[,] Matrix)
        {
            int sum = 0;
            int j = Matrix.GetLength(1) - 1;
            for (int i = 0;i<Matrix.GetLength(0);i++)
            {                  
                    sum += Matrix[i, j];
                    j--;
            }

            return sum;
        }

        public int SumOfBorder(int[,] Matrix)
        {
            int sum = 0;

            for (int i=0;i<Matrix.GetLength(1);i++)
            {
                sum += Matrix[0,i];
            }

            return sum;
        }

        public void PrintMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public int SumofTriangleLow(int[,] Matrix)
        {
            int sum = 0;

            for (int i=0;i<Matrix.GetLength(0);i++)
            {
                for (int j=0;j<=i;j++)
                {
                    sum += Matrix[i,j];
                }
            }

            return sum;
        }

        public int SumOfTriangleOn(int[,] Matrix)
        {
            int sum = 0;
            
            for (int i=0;i<Matrix.GetLength(0);i++)
            {
                for (int j = Matrix.GetLength(1) - 1; j+i>=Matrix.GetLength(1)-1;j--)
                {
                    sum += Matrix[i,j];
                }
            }

            return sum;
        }
    }
}
