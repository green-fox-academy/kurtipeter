using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override string WantChild()
        {
            return "want a child from an egg";
        }
    }
}
