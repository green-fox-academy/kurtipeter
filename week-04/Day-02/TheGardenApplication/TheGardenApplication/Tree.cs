using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {

        }

        public override string NeedWater()
        {
            if (GetCurrentWater < 10)
            {
                return String.Format("The {0} Tree needs water", GetColor);
            }
            else
            {
                return String.Format("The {0} Tree doesn't need water", GetColor);
            }
        }

        public override double WaterAbsorbtion(double gotWatered)
        {
            double absorbedWater = gotWatered * 0.4;
            return absorbedWater;
        }
    }
}
