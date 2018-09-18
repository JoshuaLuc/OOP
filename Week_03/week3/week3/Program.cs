using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake Steve = new Snake(4, "Steve", .3f);
            Dog Jack = new Dog(7, "Jack", .7f, 4);
            Cat Kitty = new Cat(2, "Kitty", .5f, 3);


            Console.WriteLine(Convert.ToString(Steve.Hunger) + (Steve.Name) + (Steve.Life));
            Console.ReadLine();
        }
    }
}
