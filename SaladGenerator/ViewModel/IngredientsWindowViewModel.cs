using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SaladGenerator.DB;
using SaladGenerator.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace SaladGenerator.ViewModel
{
    class IngredientsWindowViewModel : INotifyPropertyChanged
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

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<IngredientTypes> Types { get; set; } = new List<IngredientTypes>();
        public ICommand ClickCommand { get; set; }
        public string NewName { get; set; }
        public IngredientTypes NewType { get; set; }

        public IngredientsWindowViewModel()
        {
            ClickCommand = new RelayCommand(arg => _AddIngredient());
            _FillIngredients();
            _FillTypes();
        }

        private void _AddIngredient()
        {
            ctx.Ingredients.Add(new Ingredient { Name = NewName, Type = NewType});
            ctx.SaveChanges();
            NotifyPropertyChanged();
        }

        private void _FillIngredients()
        {
            var q = (from a in ctx.Ingredients
                     select a).ToList();
            this.Ingredients = q;
        }

        private void _FillTypes()
        {
            var q = Enum.GetValues(typeof(IngredientTypes));
            foreach(IngredientTypes i in q)
            this.Types.Add(i);
        }
    }
}
