using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        static public int[] SumArray(int[] arrayX, int[] arrayY)
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
        static public double[] SumArray(double[] arrayX, double[] arrayY)
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
        static public double[] SumArray(double[] arrayX, double value)
        {
            if (arrayX == null) { return null; }
            else
            {
                for (int i = 0; i < arrayX.Length; i++)
                {
                    arrayX[i] = arrayX[i] + value;
                }
                return arrayX;
            }
        }

        static public int[] MultipkicationArray(int[] arrayX, int[] arrayY)
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
        static public double[] MultipkicationArray(double[] arrayX, double[] arrayY)
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
        static public double[] MultipkicationArray(double[] arrayX, double value)
        {
            if (arrayX == null) { return null; }
            else
            {
                for (int i = 0; i < arrayX.Length; i++)
                {
                    arrayX[i] = arrayX[i] * value;
                }
                return arrayX;
            }
        }

            static public int[] SubtractionArray(int[] arrayX, int[] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else
            {
                int[] sumArray = new int[arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sumArray[i] = arrayX[i] - arrayY[i];
                }
                return sumArray;
            }
        }
        static public double[] SubtractionArray(double[] arrayX, double[] arrayY)
        {
            if (arrayX == null || arrayY == null) { return null; }
            else if (arrayX.Length != arrayY.Length) { return null; }
            else
            {
                double[] sumArray = new double[arrayX.Length];
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sumArray[i] = arrayX[i] - arrayY[i];
                }
                return sumArray;
            }
        }
        static public double[] SubstractionArray(double[] arrayX, double value)
        {
            if (arrayX == null) { return null; }
            else
            {
                for (int i = 0; i < arrayX.Length; i++)
                {
                    arrayX[i] = arrayX[i] - value;
                }
                return arrayX;
            }
        }

    }
}
