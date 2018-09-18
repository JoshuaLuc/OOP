using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Animal
    {

        public Animal(int life, string name, float hunger)
        {
            Life = life;
            Name = name;
            Hunger = hunger;
        }
        public int Life { get; set; }
        public string Name { get; set; }
        public float Hunger { get; set; }
        public abstract string move();
        public abstract string poop();
        public abstract string feed();


    }
}
