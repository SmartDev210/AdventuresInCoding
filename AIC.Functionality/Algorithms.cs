using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Functionality
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++) factorial *= i;
            return factorial;
        }

        public static string BuildFormattedString(List<string> items)
        {
            string formatted = string.Empty;
            if (items.Count == 0)
            {   
            }
            else if (items.Count == 1)
            {
                formatted = items.First();
            } else
            {
                for (var i = 0; i < items.Count - 1; i ++)
                {
                    formatted += items[i] + ", ";
                }
                formatted += $"and {items[^1]}";
            }

            return formatted + "!";
        }
    }
}
