using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDispose
{
    class Program
    {
        private class DisposableTest : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("DISPOSED CODE");
            }
        }

        static void Main(string[] args)
        {
            // Using
            using (DisposableTest obj = new DisposableTest())
            {
                Console.WriteLine("Using case");
            }

            // Dispose
            DisposableTest obj2 = new DisposableTest();
            Console.WriteLine("Dispose case");
            obj2.Dispose();
            Console.Read();

        }

    }
}
