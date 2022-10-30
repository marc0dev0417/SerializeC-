using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    internal class Food
    {
        public int id { get; set; }
        public string name { get; set; }

        public Food(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
         
    }
}
