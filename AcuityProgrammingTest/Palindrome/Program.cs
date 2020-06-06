using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> palindromes = new List<string>();
            Console.Write("Enter list of words separated by comma:");
            string input = Console.ReadLine();
            string[] inputStrings = input.Split(',');
            foreach(string arg in inputStrings)
            {
                if (arg.Trim().ToLower() == reverse(arg.Trim().ToLower()))
                //if(isPalindrome(arg.Trim().ToLower()))
                    palindromes.Add(arg);
            }
            Console.WriteLine(string.Join(",", palindromes.ToArray()));
            Console.ReadKey();
        }

        private static string reverse(string arg)
        {
            char[] array = arg.ToArray();
            Array.Reverse(array);
            return new string(array);
        }

        private static bool isPalindrome(string arg)
        {
            bool result = false;
            int len = arg.Length;
            int mid = len / 2;
            int i = 0;
            for(int j = len - 1; (len % 2 == 1?i < mid && j > mid: i < mid && j >= mid); i++, j--)
            {
                if (arg[i] != arg[j])
                    break;
            }
            if (i == mid)
                result = true;
            return result;
        }
    }
}
