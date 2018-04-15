using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ThirtyDaysOfCode.Day11_2DArray
{
    class Solution
    {
        public void solve()
        {
            //As arr[i][j] ranges from -9 to 9. Hence the minimum should be -9*7
            const int min = -63;
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int maxSum = min;
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                if ((i + 2) >= 6)
                    break;
                for (int j = 0; j < 6; j++)
                {
                    sum = 0;
                    if ((j + 2) >= 6)
                        break;
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (sum >= maxSum)
                        maxSum = sum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
