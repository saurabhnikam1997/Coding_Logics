using System;
using System.Text;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.GetRString("Saurabh");
            Program.ReverseWordOrder("Saurabh is good boy");
            Program.ReverseString("Gitamrutam");

            
            Console.ReadLine();
        }

        internal static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length -1; i< j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        //optimised way 3 iteration
        private static void R_String(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string rev_string = new string(charArray);
            Console.WriteLine(rev_string);

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {

            }
        }

        public static void GetRString(string str)
        {

            for (int i = str.Length-1; i >=0; i--)
            {
                Console.WriteLine(str[i]);
            }
            
        }


        internal static void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }

            int k = 10;
            int d = ++k + k++;
            Console.WriteLine(reverseSentence.ToString());
        }

        
    }
}
