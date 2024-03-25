using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Sweet : ISweet
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public Sweet(string name, double weight) 
        {
            Name = name;
            Weight = weight;
        }
        public virtual string GetDescription()
        {
            return $"This is: {Name}, with {Weight}g weight";
        }
    }
}
