using System;
using System.Linq;

namespace firstconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = null;
            if (args.Length == 0) {
                message = "Hello from xemmel's .NET Core tutorial!";
            }
            else {
                message = args.First();
            }
            Console.WriteLine();
            Console.WriteLine($"The message:\r\n{message}\r\nContains {message.WordCount()} words");
            Console.WriteLine();
        }
    }

    public static class Extensions
    {
        public static int WordCount(this string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return 0;
            string[] words = message.Split(' ');
            return words.Count();
        }
    }
}