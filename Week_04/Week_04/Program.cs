using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_04
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<int> numbers = new List<int>();



            try
            {



            int sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();


            }
            catch(Exception)
            {

            }
            Console.ReadLine();
        }
    }
}
