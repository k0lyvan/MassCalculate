using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassCalculate
{
    static public class TwoArrays
    {
        public static int[,] SumArrays(int [,] arrayX, int[,] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else if (arrayX.GetUpperBound(0) != arrayY.GetUpperBound(0) || arrayX.GetUpperBound(1) != arrayY.GetUpperBound(1))
            { return null; }
            else
            {
                int[,] sumArray = new int[arrayX.GetUpperBound(0)+1,arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    for (int j = 0; j < arrayX.GetUpperBound(0)+1; j++)
                        sumArray[i,j] = arrayX[i,j] + arrayY[i,j];
                }
                return sumArray;
            }
        }
        public static double[,] SumArrays(double[,] arrayX, double[,] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else if (arrayX.GetUpperBound(0) != arrayY.GetUpperBound(0) || arrayX.GetUpperBound(1) != arrayY.GetUpperBound(1))
            { return null; }
            else
            {
                double[,] sumArray = new double[arrayX.GetUpperBound(0)+1,arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    for (int j = 0; j < arrayX.GetUpperBound(0)+1; j++)
                        sumArray[i,j] = arrayX[i,j] + arrayY[i,j];
                }
                return sumArray;
            }
        }

        public static int[,] SubtractionArrays(int[,] arrayX, int[,] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else if (arrayX.GetUpperBound(0) != arrayY.GetUpperBound(0) || arrayX.GetUpperBound(1) != arrayY.GetUpperBound(1))
            { return null; }
            else
            {
                int[,] sumArray = new int[arrayX.GetUpperBound(0) + 1, arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    for (int j = 0; j < arrayX.GetUpperBound(0) + 1; j++)
                        sumArray[i, j] = arrayX[i, j] - arrayY[i, j];
                }
                return sumArray;
            }
        }
        public static double[,] SubtractionArrays(double[,] arrayX, double[,] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else if (arrayX.GetUpperBound(0) != arrayY.GetUpperBound(0) || arrayX.GetUpperBound(1) != arrayY.GetUpperBound(1))
            { return null; }
            else
            {
                double[,] sumArray = new double[arrayX.GetUpperBound(0) + 1, arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    for (int j = 0; j < arrayX.GetUpperBound(0) + 1; j++)
                        sumArray[i, j] = arrayX[i, j] - arrayY[i, j];
                }
                return sumArray;
            }
        }

        public static int[,] MultiplicationArrays(int[,] arrayX, int[,] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else if (arrayX.GetUpperBound(1) != arrayY.GetUpperBound(0))
            { return null; }
            else
            {
                int rang = arrayX.GetUpperBound(0) + 1;
                int[,] resArray = new int[rang, rang];
                for (int i = 0; i < rang; i++)
                {
                    for (int j = 0; j < rang; j++)
                    {
                        int c = 0;
                        for (int k = 0; k <= rang; k++)
                            c += arrayX[i, k] * arrayY[k, j];
                        resArray[i, j] = c;
                    }
                }
                return resArray;
            }
        }
    }
}
