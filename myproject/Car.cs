using System;

namespace Myclass // Note: actual namespace depends on the project name.
{
   
   public class Car 
    {
        public string mark;
        public int year;
        static public string planet = "Terre";
       public Car (string marque, int an) {
            this.mark = marque;
            this.year = an;
        }
    }
}