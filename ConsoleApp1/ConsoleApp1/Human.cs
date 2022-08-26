using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Human
    {
        public string firstName;
        private string lastName;

        public Human (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void present()
        {
            Console.WriteLine("Je me nom {1} {0}", firstName, lastName);
        }
    }
}
