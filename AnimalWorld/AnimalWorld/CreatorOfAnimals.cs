
using AnimalWorld.Continents;
using AnimalWorld.Families;

namespace AnimalWorld
{
    public class CreatorOfAnimals
    {
        private Herbivore herbivoreAnimal;
        private Carnivore carnivoreAnimal;

        public Herbivore CreateHerbivore(Continent continent)
        {
            herbivoreAnimal = continent.CreateHerbivoreAnimal();
            return herbivoreAnimal;
        }

        public Carnivore CreateCarnivore(Continent continent)
        {
            carnivoreAnimal = continent.CreateCarnivoreAnimal();
            return carnivoreAnimal;
        }
        public Herbivore CreateHerbivore(Continent continent, int _weight)
        {
            herbivoreAnimal = continent.CreateHerbivoreAnimal(_weight);
            return herbivoreAnimal;
        }

        public Carnivore CreateCarnivore(Continent continent, int _power)
        {
            carnivoreAnimal = continent.CreateCarnivoreAnimal(_power);
            return carnivoreAnimal;
        }
    }
}
