using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Library
{
    public static class Numbers
    {
        public static int[] getPrimeFactors(int n)
        {
            string result = "";
            for (int i = 2; i <= n; i++)
            {
                if ((n % i) == 0)
                    result = String.Format("{0}{1} ", result, i.ToString());
            }
            return result.Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        }
    }
}
