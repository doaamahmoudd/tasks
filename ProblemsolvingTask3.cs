using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the text: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the text to be encrypted: ");
            string input = Console.ReadLine();
            Console.Write("Enter the encryption key: ");
            int key = int.Parse(Console.ReadLine());

            key = key % 26;

            string encrypted = "";

            foreach (char c in input)
            {
                if(char.IsLetter(c))
                {
                    char baseChar =char.IsUpper(c)? 'A' : 'a';
                    char newchar = (char) ((c- baseChar+ key) % 26+ baseChar);
                    encrypted += newchar;
                }
                else
                {
                    encrypted += c;
                }
            }
            Console.WriteLine(encrypted);
            Console.ReadLine();
        }
    }
}
