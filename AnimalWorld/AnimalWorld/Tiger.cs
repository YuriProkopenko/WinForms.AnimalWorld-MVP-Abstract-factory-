using System;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Animals
    {
        class Tiger: Carnivore
        {
            public override int Power { get; set; }
            public override bool isAlive { get; set; }
            public Tiger()
            {
                Random rnd = new Random();
                Power = rnd.Next(90, 105);
                isAlive = true;
            }
            public Tiger(int _power)
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
                        Power += rnd.Next(25, 35);
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
