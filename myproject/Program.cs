using System;
using Informatique;
using sc = System.Console;


namespace Inheritance
{

struct Rectangle {
    public int largeur;
    public int longueur;

    public Rectangle (int ll, int lL) {
        this.largeur = ll;
        this.longueur = lL;
    }
}
 class Program {
 static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(60, 100);
        Console.WriteLine("La longueur est : " + rect.longueur);
        Console.WriteLine("La largeur est : " + rect.largeur);

      
    }

 }
   

}
