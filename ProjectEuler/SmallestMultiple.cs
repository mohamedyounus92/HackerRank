using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Library;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #5: Smallest multiple
    /// </summary>
    class SmallestMultiple
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine());
            if (1 <= T && T <= 10)
                for (int i = 0; i < T; i++)
                {
                    int N = Int32.Parse(Console.ReadLine());
                    if (1 <= N && N <= 40)
                    {
                        long result = 1;
                        for (int j = 1; j <= N; j++)
                        {
                            if ((result % j) != 0)
                            {
                                foreach (int num in Numbers.getPrimeFactors(j))
                                {
                                    if (((result * num) % j) == 0)
                                    {
                                        result *= num;
                                        break;
                                    }
                                    else
                                        result *= num;
                                }
                            }
                        }
                        Console.WriteLine(result);
                    }

                }
        }
    }
}
