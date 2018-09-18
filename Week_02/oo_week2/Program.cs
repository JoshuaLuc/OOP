using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo_week2
{
    class Program
    {
        static void Main(string[] args)
        {
           for ( int i = 1; i <100; i++)
            {
                int num1 = 0;
                int num2 = 1;
                int num3 = 0;

                for(int i = 0; i <= 7;)
                {
                    num3 = num1 + num2;
                    num1 = num2;
                    num2 = num3; 


                }
            }

            }
    }
}
