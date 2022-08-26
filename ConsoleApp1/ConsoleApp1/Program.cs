using ConsoleApp1;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new human
            Human human = new Human("Bahi", "Yekpahi");
            Console.WriteLine("{0} {1}", human.firstName, human.lastName);
        }
    }
}


