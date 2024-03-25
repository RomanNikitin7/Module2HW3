using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Lollipop : Candy
    {
        public string Color { get; set; }
        public Lollipop(string name, double weight, string flavor, string color) : base(name, weight, flavor)
        {
            Color = color;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + $", color: {Color}";
        }
    }
}
