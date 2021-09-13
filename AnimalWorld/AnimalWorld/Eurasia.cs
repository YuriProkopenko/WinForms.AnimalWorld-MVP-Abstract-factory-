
using AnimalWorld.Animals;
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Continents
    {
        class Eurasia : Continent
        {
            public override Herbivore CreateHerbivoreAnimal()
            {
                return new Elk();
            }

            public override Carnivore CreateCarnivoreAnimal()
            {
                return new Tiger();
            }
            public override Herbivore CreateHerbivoreAnimal(int _weight)
            {
                return new Elk(_weight);
            }

            public override Carnivore CreateCarnivoreAnimal(int _power)
            {
                return new Tiger(_power);
            }
        }
    }
}
