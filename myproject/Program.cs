using System;
using Informatique;

namespace Inheritance
{

    interface Irectangle
    {
        int aire(int a, int b);
    }
    class Program : Irectangle
    {
        public int aire(int a, int b) {
            int aire = a * b;
            return aire;
        }
        static void Main(string[] args)
        {
    
            Program a1 = new Program();
            Console.WriteLine(a1.aire(10, 20));

        }

    }
}