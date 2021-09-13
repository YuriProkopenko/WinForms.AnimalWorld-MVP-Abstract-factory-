using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalWorld.Animals;
using AnimalWorld.Continents;
using AnimalWorld.Families;

namespace AnimalWorld
{
    class Model: IModel
    {
        public int LionCount { get; set; }
        public int AntelopeCount { get; set; }
        public int PumaCount { get; set; }
        public int WapitiCount { get; set; }
        public int TigerCount { get; set; }
        public int ElkCount { get; set; }
        List<Carnivore> lion;
        List<Carnivore> puma;
        List<Carnivore> tiger;
        List<Herbivore> antelope;
        List<Herbivore> wapiti;
        List<Herbivore> elk;
        public Model() { }
        public void CreateAnimals()
        {
            lion = new List<Carnivore>(LionCount);
            puma = new List<Carnivore>(PumaCount);
            tiger = new List<Carnivore>(TigerCount);
            antelope = new List<Herbivore>(AntelopeCount);
            wapiti = new List<Herbivore>(WapitiCount);
            elk = new List<Herbivore>(ElkCount);
            for (int i = 0; i < LionCount; i++)
                lion.Add(new Lion());
            for (int i = 0; i < PumaCount; i++)
                puma.Add(new Puma());
            for (int i = 0; i < TigerCount; i++)
                tiger.Add(new Tiger());
            for (int i = 0; i < AntelopeCount; i++)
                antelope.Add(new Antelope());
            for (int i = 0; i < WapitiCount; i++)
                wapiti.Add(new Wapiti());
            for (int i = 0; i < ElkCount; i++)
                elk.Add(new Elk());
        }
        public void FeedingHerbivores()
        {
            foreach(var herbivore in antelope)
            {
                herbivore.EatGrass();
            }
            foreach(var herbivore in wapiti)
            {
                herbivore.EatGrass();
            }
            foreach(var herbivore in elk)
            {
                herbivore.EatGrass();
            }
        }
        public void FeedingCarnivores()
        {
            Random rnd = new Random();
            for (int i = 0; i < LionCount; i++)
            {
                int random = rnd.Next(0, AntelopeCount);
                if (random != 0)
                {
                    lion[i].EatHerbivore(antelope[random - 1]);
                    if (antelope[random - 1].isAlive == false)
                    {
                        antelope.RemoveAt(random - 1);
                        AntelopeCount = antelope.Count();
                        continue;
                    }
                }
                lion[i].Power -= 10;
                if (lion[i].Power <= 0)
                {
                    lion.RemoveAt(i);
                    LionCount = lion.Count();
                }
            }
            for (int i = 0; i < PumaCount; i++)
            {
                int random = rnd.Next(0, WapitiCount);
                if (random != 0)
                {
                    puma[i].EatHerbivore(wapiti[random - 1]);
                    if (wapiti[random - 1].isAlive == false)
                    {
                        wapiti.RemoveAt(random - 1);
                        WapitiCount = wapiti.Count();
                        continue;
                    }
                }
                puma[i].Power -= 10;
                if (puma[i].Power <= 0)
                {
                    puma.RemoveAt(i);
                    PumaCount = puma.Count();
                }
            }
            for (int i = 0; i < TigerCount; i++)
            {
                int random = rnd.Next(0, ElkCount);
                if (random != 0)
                {
                    tiger[i].EatHerbivore(elk[random - 1]);
                    if (elk[random - 1].isAlive == false)
                    {
                        elk.RemoveAt(random - 1);
                        ElkCount = elk.Count();
                        continue;
                    }
                }
                tiger[i].Power -= 10;
                if (tiger[i].Power <= 0)
                {
                    tiger.RemoveAt(i);
                    TigerCount = tiger.Count();
                }
            }
        }
    }
}
