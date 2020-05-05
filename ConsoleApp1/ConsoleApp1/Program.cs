using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regularExpression = new Regex(@"\D");
            Console.WriteLine("Put your input or put 'exit' to terminate");
            string input = Console.ReadLine();
            while (input!= "exit"){
                string result = regularExpression.Replace(input, "");
                int intResult = StrToInt(result);
                Console.WriteLine(intResult);
                Console.WriteLine(intResult.GetType());
                Console.WriteLine("Put another your input or put 'exit' to terminate");
                input = Console.ReadLine();
            }
        }
        static int StrToInt(string str)
        {
            int response = 0;
            foreach (char c in str)
            {
                response *= 10;
                response += c - '0';
            }
            return response;
        }
    }
}
