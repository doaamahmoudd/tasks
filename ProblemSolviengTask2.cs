using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(121));
            Console.WriteLine(solution.IsPalindrome(-121));
            Console.WriteLine(solution.IsPalindrome(10));

            Console.ReadKey();

        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int reverse = 0;
            int x_original = x;
            while (x > 0)
            {
                reverse = (reverse * 10) + (x % 10);
                x /= 10;
            }
            return reverse == x_original;


        }
    }
}
