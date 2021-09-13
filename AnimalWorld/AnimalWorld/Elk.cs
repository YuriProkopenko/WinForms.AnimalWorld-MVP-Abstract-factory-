using System;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Animals
    {
        class Elk: Herbivore
        {
            public override int Weight { get; set; }
            public override bool isAlive { get; set; }
            public Elk()
            {
                Random rnd = new Random();
                Weight = rnd.Next(75, 80);
                isAlive = true;
            }
            public Elk(int _weight)
            {
                Weight = _weight;
                isAlive = true;
            }
            public override void EatGrass()
            {
                Random rnd = new Random();
                Weight += rnd.Next(15, 30);
            }
        }
    }
}
