﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Mammal : Animal
    {
        public Mammal(int life, string name, float hunger, int legs) : base(life,name,hunger)
        {

        }
    }
}
