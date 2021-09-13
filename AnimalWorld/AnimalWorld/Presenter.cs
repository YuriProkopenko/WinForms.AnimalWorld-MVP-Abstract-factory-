using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Presenter
    {
        public int LionCount { get; set; }
        public int AntelopeCount { get; set; }
        public int PumaCount { get; set; }
        public int WapitiCount { get; set; }
        public int TigerCount { get; set; }
        public int ElkCount { get; set; }
        public int Period { get; set; }
        private readonly IModel model;
        private readonly IView view;
        public Presenter(IModel _model, IView _view)
        {
            model = _model;
            view = _view;
            view.updateModel += new EventHandler<EventArgs>(UpdateModel);
            view.getPopulationResults += new EventHandler<EventArgs>(PopulateResult);
        }
        private void UpdateModel(object sender, EventArgs e)
        {
            model.LionCount = view.LionCount;
            model.PumaCount = view.PumaCount;
            model.TigerCount = view.TigerCount;
            model.WapitiCount = view.WapitiCount;
            model.AntelopeCount = view.AntelopeCount;
            model.ElkCount = view.ElkCount;
            Period = view.Period;
        }
        private void UpdateView(object sender, EventArgs e)
        {
            view.LionCount = model.LionCount;
            view.PumaCount = model.PumaCount;
            view.TigerCount = model.TigerCount;
            view.WapitiCount = model.WapitiCount;
            view.AntelopeCount = model.AntelopeCount;
            view.ElkCount = model.ElkCount;
            view.Period = Period;
        }
        private void PopulateResult(object sender, EventArgs e)
        {
            model.CreateAnimals();
            for (int i = 0; i < Period; i++)
            {
                model.FeedingHerbivores();
                model.FeedingCarnivores();
            }
            Period = 0;
            UpdateView(sender, e);
        }
    }
}
