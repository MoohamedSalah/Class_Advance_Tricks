using System;
using System.Linq;

namespace System 
{
    public static class StringExtention 
    {
        public static string shortString(this string arg, int numberofwords)
        {
            if (numberofwords < 0)
                return "put number grater than of 0";

            if (numberofwords == 0)
                return"";
            var Word = arg.Split(' ');

            if (Word.Length <= numberofwords)
                return arg;

          

            return string.Join(" ", Word.Take(numberofwords).ToList())+"...";
        }
    }
}
