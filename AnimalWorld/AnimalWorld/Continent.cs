
using AnimalWorld.Families;

namespace AnimalWorld
{
    namespace Continents
    {
        public abstract class Continent
        {
            public abstract Herbivore CreateHerbivoreAnimal();
            public abstract Carnivore CreateCarnivoreAnimal();
            public abstract Herbivore CreateHerbivoreAnimal(int _weight);
            public abstract Carnivore CreateCarnivoreAnimal(int _power);
        }
    }
}
