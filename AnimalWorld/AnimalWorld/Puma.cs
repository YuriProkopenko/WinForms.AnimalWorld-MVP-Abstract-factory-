using System;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Animals
    {
        public class Puma : Carnivore
        {
            public override int Power { get; set; }
            public override bool isAlive { get; set; }
            public Puma()
            {
                Random rnd = new Random();
                Power = rnd.Next(45, 60);
                isAlive = true;
            }
            public Puma(int _power)
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
                        Power += rnd.Next(5, 15);
                    }
                    else
                    {
                        Power -= 5;
                    }
                }
            }
        }
    }
}
