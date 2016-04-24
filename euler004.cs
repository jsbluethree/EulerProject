// Euler Project #4 in C#
// Find the largest palindrome made from the product of two 3-digit numbers.

using System;
using System.Collections.Generic;
using System.Linq;

namespace euler004
{
    static class euler004
    {
        static void Main()
        {
            var products =
                from i in RangeTo999()
                from j in RangeTo999()
                select i * j;
            var palindrome = products
                .OrderByDescending(a => a)
                .First(a => a.ToString().IsPalindrome());
            Console.WriteLine(palindrome);
        }

        static IEnumerable<int> RangeTo999()
        {
            for (int i = 1; i < 1000; ++i)
                yield return i;
        }

        static bool IsPalindrome(this string str)
        {
            for (int i = 0; i < str.Length / 2; ++i)
            {
                if (str[i] != str[str.Length - (i+1)])
                    return false;
            }
            return true;
        }
    }
}
