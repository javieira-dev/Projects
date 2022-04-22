using System;
using System.Text;

namespace EstudandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ABC";
            string string2 = "DEF";
            Console.WriteLine(string1 + string2);
            Console.WriteLine("==========================================================");
            StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append("");
            sb.Append(string2);
            Console.WriteLine(sb.ToString());
        }
    }
}
