using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Challenge
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string colour, int side1Length, int side2Length) : base(colour, side1Length, side2Length, side1Length, side2Length)
        {

        }
        public int GetArea()
        {
            int area = Side1Length * Side2Length;
            return area;
        }
    }
}
