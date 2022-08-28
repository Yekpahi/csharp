using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    /*class Present {
        public string nom;
        public string prenom;

        public void presentation () {
            Console.WriteLine("Je me nomme {0} {1}", prenom, nom);
        }
    }*/

    class Student {
        protected string name;
    }
    internal class Program : Student
    {

        static void Main(string[] args)
        {
           Program p1 = new Program();
           p1.name = "Charles";

           Console.WriteLine(p1.name);
        }
    }
}