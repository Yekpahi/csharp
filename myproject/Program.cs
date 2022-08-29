using System;
using Myclass;

namespace MyApp // Note: actual namespace depends on the project name.
{
   
    internal class Program 
    {
        string mygram;

        //static properties

        static string classname = "Class A";

        static void present() {
            Console.WriteLine("My class is " + classname);
        }

        Program (string gram) {
            this.mygram = gram;
        }

        Program (Program p) {
            this.mygram = p.mygram;
        }
        static void Main(string[] args)
        {
          Car c1 = new Car("Toyota", 2016);
          Console.WriteLine("La marque de ma voiture est {0}. Elle est de {1}", c1.mark, c1.year);
          /* PROGRAMMME*/
        Program pr1 = new Program("Python");
        Console.WriteLine("Brand of car1: " + pr1.mygram);

         Program pr2 = new Program(pr1);
        Console.WriteLine("Brand of car2: " + pr2.mygram);
        Console.WriteLine("My planet " + Car.planet);

        Console.WriteLine(classname);
        present();

        }
    }
}