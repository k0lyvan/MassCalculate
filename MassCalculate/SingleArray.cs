using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassCalculate
{
    static public class SingleArray
    {
        static public int SumArray(int[] array)
        {
            if (array == null) { return 0; }
            else
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum += i;
                }
                return sum;
            }
        }
        static public double SumArray(double[] array)
        {
            if (array == null) { return 0; }
            else
            {
                double sum = 0;
                foreach (double i in array)
                {
                    sum += i;
                }
                return sum;
            }
        }

        static public int[] SumTwoArray(int[] arrayX, int[] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else
            {
                int[] sumArray = new int[arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sumArray[i] = arrayX[i] + arrayY[i];
                }
                return sumArray;
            }
        }
        static public double[] SumTwoArray(double[] arrayX, double[] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else
            {
                double[] sumArray = new double[arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sumArray[i] = arrayX[i] + arrayY[i];
                }
                return sumArray;
            }
        }

        static public int[] MultipkicationTwoArray(int[] arrayX, int[] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else
            {
                int[] sumArray = new int[arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sumArray[i] = arrayX[i] * arrayY[i];
                }
                return sumArray;
            }
        }
        static public double[] MultipkicationTwoArray(double[] arrayX, double[] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else
            {
                double[] sumArray = new double[arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sumArray[i] = arrayX[i] * arrayY[i];
                }
                return sumArray;
            }
        }
    }
}
