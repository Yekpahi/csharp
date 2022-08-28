using ConsoleApp1;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
         Box box = new Box();
            box.id = 66210202;
            box.name = "Prince Bai";
            Console.WriteLine(box.id);
            Console.WriteLine(box.name);

        }
    }
}


