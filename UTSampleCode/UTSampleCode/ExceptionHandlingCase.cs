using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSampleCode
{
   public class ExceptionHandlingCase
    {
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public int Smallest(int[] arr)
        {
            int result = arr[0];
            for(int i =1; i<arr.Length; i++)
            {
                if(result > arr[i])
                {
                    result = arr[i];
                }
            }

            return result;
        }

    }
}
