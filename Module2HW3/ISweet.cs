using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal interface ISweet
    {
        public string Name { get; }
        public double Weight {  get; }
        public string GetDescription();
    }
}
