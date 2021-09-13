
namespace AnimalWorld
{
    namespace Families
    {
        public abstract class Herbivore
        {
            public abstract int Weight { get; set; }
            public abstract bool isAlive { get; set; }
            public abstract void EatGrass();
        }
    }
}
