using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassCalculate
{
    static internal class SingleArray
    {
        static internal int SumArray(int[] array)
        {
            if (array == null) { return 0; }
            else
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum += array[i];
                    
                }
                return sum;
            }
        }
        static internal double SumArray(double[] array)
        {
            if (array == null) { return 0; }
            else
            {
                double sum = 0;
                foreach (double i in array)
                {
                    sum += array[i];

                }
                return sum;
            }
        }
    }
}
