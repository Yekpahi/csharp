using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
   
    internal class Program 
    {
      
        static void Main(string[] args)
        {
          string str1 = "C# Programming ";
            string str2 = "and C Programming";

            string conc = string.Concat(str1, str2);

            Console.WriteLine(conc);

        }
    }
}