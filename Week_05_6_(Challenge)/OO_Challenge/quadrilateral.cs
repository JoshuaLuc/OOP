using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Challenge
{
     public class Quadrilateral : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }

        public Quadrilateral(string colour, int side1Length, int side2Length, int side3Length, int side4Length) : base(colour)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
            Side4Length = side4Length;
        }
        public int GetPerimeter()
        {
            int perimeter = Side1Length + Side2Length + Side3Length + Side4Length;
            return perimeter;
        }
    }
}
