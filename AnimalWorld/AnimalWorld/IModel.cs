using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public interface IModel
    {
        public int LionCount { get; set; }
        public int AntelopeCount { get; set; }
        public int PumaCount { get; set; }
        public int WapitiCount { get; set; }
        public int TigerCount { get; set; }
        public int ElkCount { get; set; }
        public void CreateAnimals();
        public void FeedingHerbivores();
        public void FeedingCarnivores();
    }
}
