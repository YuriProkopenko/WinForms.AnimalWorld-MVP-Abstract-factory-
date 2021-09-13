
using AnimalWorld.Families;
using AnimalWorld.Animals;

namespace AnimalWorld
{
    namespace Continents
    {
        public class Africa : Continent
        {
            public override Herbivore CreateHerbivoreAnimal()
            {
                return new Antelope();
            }

            public override Carnivore CreateCarnivoreAnimal()
            {
                return new Lion();
            }
            public override Herbivore CreateHerbivoreAnimal(int _weight)
            {
                return new Antelope(_weight);
            }

            public override Carnivore CreateCarnivoreAnimal(int _power)
            {
                return new Lion(_power);
            }
        }
    }
}
