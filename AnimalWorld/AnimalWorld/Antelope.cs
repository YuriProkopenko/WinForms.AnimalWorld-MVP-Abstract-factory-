using System;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Animals
    {
        public class Antelope : Herbivore
        {
            public override int Weight { get; set; }
            public override bool isAlive { get; set; }
            public Antelope()
            {
                Random rnd = new Random();
                Weight = rnd.Next(60, 70);
                isAlive = true;
            }
            public Antelope(int _weight)
            {
                Weight = _weight;
                isAlive = true;
            }
            public override void EatGrass()
            {
                Random rnd = new Random();
                Weight += rnd.Next(10, 20);
            }
        }
    }
}
