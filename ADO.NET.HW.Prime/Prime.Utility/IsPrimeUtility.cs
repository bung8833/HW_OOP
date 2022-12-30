using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime.Utility
{
    public class IsPrimeUtility
    {
        public static bool IsPrime(int N)
        {
            if (N <= 1) return false;
            if (N == 2) return true;
            if (N % 2 == 0) return false;
            
            for (int i = 3; i <= Math.Sqrt(N); i+=2)
            {
                if (N % i == 0) return false;
            }
            
            return true;
        }
    }
}
