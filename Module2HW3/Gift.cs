using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Gift
    {
        public double CalculateTotalWeight(ISweet[] sweets)
        {
            double totalWeight = 0;
            foreach (var sweet in sweets)
            {
                totalWeight += sweet.Weight;
            }
            return totalWeight;
        }

        public void SortByName(ISweet[] sweets)
        {
            Array.Sort(sweets, (x, y) => String.Compare(x.Name, y.Name));
        }

        public ISweet FindSweetByParameter(ISweet[] sweets, bool isChocolate, double minWeight, string name)
        {
            foreach (var sweet in sweets)
            {
                if (isChocolate && sweet is Chocolate && sweet.Weight > minWeight && sweet.Name == name)
                {
                    return sweet;
                }
            }
            return null;
        }
    }
}
