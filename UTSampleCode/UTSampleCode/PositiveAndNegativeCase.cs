using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSampleCode
{
  public class PositiveAndNegativeCase
    {
            public bool IsPrime(int a)
            {
                bool result = true;
                if (a >= 0)
                {
                    for (int i = 2; i <= a / 2; i++)
                    {
                        if (a % i == 0)
                        {
                            result = false;
                            break;
                        }
                    }

                   return result;
                }
                else
                {
                    return false;
                }
               
            } 
    }
}
