using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Candy : Sweet
    {
        public string Flavor { get; set; }
        public Candy(string name, double weight, string flavor) : base(name, weight)
        {
            Flavor = flavor;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" with flavor {Flavor}";
        }
    }
}
