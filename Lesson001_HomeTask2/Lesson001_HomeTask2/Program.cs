using System;
using System.Text;

namespace Lesson001_HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string myStr1 = "\nмій рядок 1";
            string myStr2 = "\tмій рядок 2";
            string myStr3 = "\aмій рядок 3";
            Console.WriteLine(myStr1);
            Console.WriteLine(myStr2);
            Console.WriteLine(myStr3);
        }
    }
}
