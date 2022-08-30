using System;
using Informatique;
using sc = System.Console;


namespace MyNamespace
{
    public class SampleClass
    {
        public static void myMethod()
        {
            Console.WriteLine("Creating my namespace");
        }
    }
}



namespace Inheritance
{
 class Program {
 static void Main(string[] args)
    {

      MyNamespace.SampleClass.myMethod();
    }

 }
   

}
