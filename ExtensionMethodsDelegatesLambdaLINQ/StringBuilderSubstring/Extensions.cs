/*
 * Problem 1. StringBuilder.Substring
 * ===================================
 * Implement an extension method Substring(int index, int length) for the class 
 * StringBuilder that returns new StringBuilder and has the same functionality as Substring 
 * in the class String.
 * =========================================================================================
 */
 namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder builder, int index, int length)
        {
            if (index < 0 || index >= builder.Length || index + length >= builder.Length)
            {
                throw new IndexOutOfRangeException();
            }
            var substring = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                substring.Append(builder.ToString()[i]);
            }
            return substring;
        }
    }
}
