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
        public ICommand ClickCommand { get; set; }
        public string NewName { get; set; }
        public IngredientTypes NewType { get; set; }

        public MainWindowViewModel()
        {
            ClickCommand = new RelayCommand(arg => _AddIngredient());
            _FillIngredients();
        }

        private void _AddIngredient()
        {
            ctx.Ingredients.Add(new Ingredient { Name = NewName, Type = NewType});
            ctx.SaveChanges();
        }

        private void _FillIngredients()
        {
            var q = (from a in ctx.Ingredients
                     select a).ToList();
            this.Ingredients = q;
        }
    }
}
