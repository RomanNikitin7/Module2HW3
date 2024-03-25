using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Chocolate : Sweet
    {
        public string Type { get; set; }
        public Chocolate(string name, double weight, string type) : base(name, weight)
        {
            Type = type;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $". Type is {Type}";
        }
    }
}
