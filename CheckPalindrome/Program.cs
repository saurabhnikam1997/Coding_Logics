using System;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome("madam");
            CheckPalindrome("");
            Console.ReadLine();
        }

        internal static void CheckPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j=str.Length-1; i < str.Length /2; i++,j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag ==true)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }
    }
}
