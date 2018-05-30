using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        protected string name;
        protected string color;
        protected string gender;
        protected int age;
        protected double weight;

        protected Animal(string name)
        {
            this.name = name;
        }

        public abstract void Greet();
        public abstract string WantChild();

        public string GetName()
        {
            return name;
        }
    }
}
