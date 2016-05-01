using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladGenerator.Model
{
    class Recipe
    {
        /// <summary>
        /// Список ингредиентов
        /// </summary>
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = new List<Ingredient>();

        }
    }
}
