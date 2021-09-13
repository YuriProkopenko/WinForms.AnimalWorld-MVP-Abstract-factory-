using System;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Animals
    {
        public class Wapiti : Herbivore
        {
            public override int Weight { get; set; }
            public override bool isAlive { get; set; }
            public Wapiti()
            {
                Random rnd = new Random();
                Weight = rnd.Next(35, 50);
                isAlive = true;
            }
            public Wapiti(int _weight)
            {
                Weight = _weight;
                isAlive = true;
            }
            public override void EatGrass()
            {
                Random rnd = new Random();
                Weight += rnd.Next(5, 15);
            }
        }
    }
}
