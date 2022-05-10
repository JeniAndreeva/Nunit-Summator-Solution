using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static int Sum(int[] arr)
        {
            checked
            {
                int sum = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
            
        }

        public static int Average(int[] arr)
        {
            checked
            {
                int sum = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum / arr.Length;
            }

        }
    }
}
