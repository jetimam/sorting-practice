using System;

namespace sorting_practice
{
    public static class Utility
    {
        public static string StringInput(string text)
        {
            Console.Write(text + "\n > ");
            return Console.ReadLine();
        }

        public static int IntInput(string text)
        {
            Console.Write(text + "\n > ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}