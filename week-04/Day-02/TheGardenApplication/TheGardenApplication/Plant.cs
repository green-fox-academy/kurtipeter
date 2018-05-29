using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Plant
    {
        private double currentWater;
        private string color;

        public Plant(string color)
        {
            this.currentWater = 0.0;
            this.color = color;
        }

        public double GetCurrentWater
        {
            get
            {
                return currentWater;
            }
        }

        public void SetCurrentWater(double change)
        {
            currentWater += change;
        }

        public string GetColor
        {
            get
            {
                return color;
            }
        }

        public virtual string NeedWater()
        {
            return "You should overwrite this in the subclass";
        }

        public virtual double WaterAbsorbtion(double gotWatered)
        {
            double absorbedWater = 0.0;
            return absorbedWater;
        }
    }
}
