using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09
{
    class Animal : Object, IMoveable, ISpeakable
    {
        string Species { get; set; }
        public string GetSpecies()
        {
            return Species;
        }

        public string Move()
        {
            throw new NotImplementedException();
        }
    }

   
}
