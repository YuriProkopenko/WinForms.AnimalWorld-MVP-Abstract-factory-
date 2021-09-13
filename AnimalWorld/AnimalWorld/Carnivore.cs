
namespace AnimalWorld
{
    namespace Families
    {
        public abstract class Carnivore
        {
            public abstract int Power { get; set; }
            public abstract bool isAlive { get; set; }
            public abstract void EatHerbivore(Herbivore herbivoreAnimal);
        }
    }
}
