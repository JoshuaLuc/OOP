using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Challenge
{
    public class Square : Quadrilateral
    {


        public  Square(string colour, int side1Length) : base (colour, side1Length , side1Length, side1Length, side1Length)
        {

        }
        public int GetArea()
        {
            int area = Side1Length * Side1Length;
            return area;
        }
    }
}
