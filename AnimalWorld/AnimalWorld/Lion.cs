using System;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Animals
    {
        public class Lion : Carnivore
        {

            public override int Power { get; set; }
            public override bool isAlive { get; set; }
            public Lion()
            {
                Random rnd = new Random();
                Power = rnd.Next(60, 85);
                isAlive = true;
            }
            public Lion(int _power)
            {
                Power = _power;
                isAlive = true;
            }
            public override void EatHerbivore(Herbivore herbivoreAnimal)
            {
                if (herbivoreAnimal != null)
                {
                    if (herbivoreAnimal.Weight <= Power)
                    {
                        herbivoreAnimal.isAlive = false;
                        Random rnd = new Random();
                        Power += rnd.Next(15, 25);
                    }
                    else
                    {
                        Power -= 10;
                    }
                }
            }
        }
    }
}
