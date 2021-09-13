
using AnimalWorld.Families;
using AnimalWorld.Animals;

namespace AnimalWorld
{
    namespace Continents
    {
        public class NorthAmerica : Continent
        {
            public override Herbivore CreateHerbivoreAnimal()
            {
                return new Wapiti();
            }

            public override Carnivore CreateCarnivoreAnimal()
            {
                return new Puma();
            }
            public override Herbivore CreateHerbivoreAnimal(int _weight)
            {
                return new Wapiti(_weight);
            }

            public override Carnivore CreateCarnivoreAnimal(int _power)
            {
                return new Puma(_power);
            }
        }
    }
}
