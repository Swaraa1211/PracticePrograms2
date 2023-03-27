using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms2
{
    internal class MaxStock
    {
        
        public static void Main(string[] args)
        {
            Console.Write("Day of Purchasing: ");
            int day = Convert.ToInt32(Console.ReadLine());
            CalculateProfit(day);
        }

        public static void CalculateProfit(int day)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4, 8 };
            int MaxProfit = prices[day-1];
            
            if (day > prices.Length)
            {
                Console.WriteLine("Out of Days!");

            }
            else
            {
                while (day != 0)
                {
                    for (int j = day; j <= prices.Length; j++)
                    {
                        if (MaxProfit <= prices[j - 1])
                        {
                            MaxProfit = prices[j - 1];
                        }
                    }
                    break;
                }
            }
            
           
            Console.WriteLine("Maximum Profit: " + MaxProfit);
        }
    }
}
/*//Console.WriteLine(MaxProfit);
            //int i = day - 1;
            //Console.WriteLine(day);
//Console.WriteLine(prices.Length);
 */
