using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #2: Even Fibonacci numbers
    /// </summary>
    class SumOfEvenFibonacci
    {
        public void solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                int temp1 = 0;
                int temp2 = 1;
                int sum = 0;
                while (true)
                {
                    temp1 += temp2;
                    if (temp1 <= n)
                    {
                        if ((temp1 % 2) == 0)
                            sum += temp1;
                    }
                    else
                        break;
                    temp1 += temp2;
                    temp2 = temp1 - temp2;
                    temp1 -= temp2;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
