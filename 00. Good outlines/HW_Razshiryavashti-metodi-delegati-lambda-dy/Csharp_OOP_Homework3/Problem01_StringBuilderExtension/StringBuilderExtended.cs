using System;
using System.Text;

class StringBuilderExtended
{
    static void Main(string[] args)
    {
        StringBuilder myStringBuilder = new StringBuilder();
        myStringBuilder.Append("Hello World");
        string str = myStringBuilder.Substring(1, 6);
        Console.WriteLine(str);
    } 
}
static class Extensions
{
    public static string Substring(this StringBuilder sb, int index, int length)
    {
        return sb.ToString().Substring(index, length);
    }
}
