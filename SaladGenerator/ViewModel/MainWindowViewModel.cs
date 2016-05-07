using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SaladGenerator.DB;
using SaladGenerator.Model;

namespace SaladGenerator.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        IngredientContext ctx = new IngredientContext();

        public List<Ingredient> Ingredients { get; set; }

        public MainWindowViewModel()
        {
            _FillIngredients();
        }

        private void _FillIngredients()
        {
            var q = (from a in ctx.Ingredients
                     select a).ToList();
            this.Ingredients = q;
        }
    }
}
