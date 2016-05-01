using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladGenerator.Model
{
    public class Recipe
    {
        /// <summary>
        /// Список ингредиентов
        /// </summary>
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = new List<Ingredient>();

            foreach (IngredientTypes suit in Enum.GetValues(typeof(IngredientTypes)))
            {
                var vv = (from i in ingredients where i.Type == suit select i).First();
                Ingredients.Add((Ingredient)vv);
            }
        }
    }
}
