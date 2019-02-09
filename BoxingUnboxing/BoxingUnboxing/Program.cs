using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("num " + num);
            
            object obj = num; // Boxing
            Console.WriteLine("obj " + obj);
            
            int num2 = (int)obj; // Unboxing
            Console.WriteLine("num2 " + obj);

            Console.Read();
        }
    }
}
