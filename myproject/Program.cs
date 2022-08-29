using System;
using Informatique;

namespace Inheritance
{


    class Program
    {

        static void Main(string[] args)
        {
    
        Logiciel l1 = new Logiciel("Maya", 2000);
        Console.WriteLine(l1.name);
        l1.presentation();

        }

    }
}