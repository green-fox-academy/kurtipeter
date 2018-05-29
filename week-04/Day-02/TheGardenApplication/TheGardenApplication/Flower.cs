using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Flower : Plant
    {
        public Flower(string color) : base(color)
        {

        }

        public override string NeedWater()
        {
            if (GetCurrentWater < 5)
            {
                return String.Format("The {0} Flower needs water", GetColor);
            }
            else
            {
                return String.Format("The {0} Flower doesn't need water", GetColor);
            }
        }

        public override double WaterAbsorbtion(double gotWatered)
        {
            double absorbedWater = gotWatered*0.75;
            return absorbedWater;
        }
    }
}
