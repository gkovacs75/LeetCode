using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0121_BestTimeToBuyAndSellStock
    {
        public void Run()
        {
            //int[] prices = [7, 1, 5, 3, 6, 4]; // 5
            int[] prices = [7, 6, 4, 3, 1]; // 0
            //int[] prices = [7, 1, 5, 3, 6, 4, 20]; // 19
            //int[] prices = [7, 4, 5, 1, 2, 8]; // 


            var r1 = MaxProfit(prices);

            Console.WriteLine(r1);
        }
        public int MaxProfit(int[] prices)
        {
            int dif = 0;

            int i = 0;

            for (int j = 1; j < prices.Length; j++)
            {                
                while (prices[i] >= prices[j] && i < j)
                {
                    i++;
                }

                if (prices[i] < prices[j] && i < j)
                {
                    if (prices[j] - prices[i] > dif)
                    {
                        dif = prices[j] - prices[i];
                    }
                }
            }

            return dif;
        }
    }
}
