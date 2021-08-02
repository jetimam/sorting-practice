using System;

namespace sorting_practice
{
    public static class Utility
    {
        public static string StringInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int IntInput(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}