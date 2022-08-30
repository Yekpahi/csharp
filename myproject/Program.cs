using System;
using Informatique;
using sc = System.Console;

namespace Inheritance
{
 class Program {
 static void Main(string[] args)
    {

        int num = 2000;

        string str = "300";

        Type n = num.GetType();

        double a = 1.25;
        int nulmInt = (int) a;

        int b = int.Parse(str);


        sc.WriteLine("Le type de {0} est {1}.", num, n);
        
        sc.WriteLine("{0} : {1}.", a, nulmInt);
         sc.WriteLine("{0} : {1}.", str, b);
    }

 }
   

}
