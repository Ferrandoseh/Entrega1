using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class Class1
    {
        public static void Hello(this String s)
        {
            Console.WriteLine(s);
            Console.WriteLine("Hello world");
        }
        public static int CountMe(this String s)
        {
            int count = s.Count();
            Console.WriteLine("I have " + count + " characters");
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String str = "I'm a string!";
            str.Hello();
            str.CountMe();
            Console.ReadKey();
        }
    }
}
