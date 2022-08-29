using System;

namespace Inheritance {

  abstract class Language {

    public void lang()
    {
        Console.WriteLine("I speak english");
    }
  }

  class Program : Language{

    static void Main(string[] args) {

        Program p = new Program();
        p.lang();

    }

  }
}