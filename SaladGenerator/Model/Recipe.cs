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

        /// <summary>
        /// Конструктор рецепта из ингредиентов
        /// </summary>
        /// <param name="ingredients">список из всех ингредиентов</param>
        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = new List<Ingredient>();

            foreach (IngredientTypes suit in Enum.GetValues(typeof(IngredientTypes)))
            {
                var vv = (from i in ingredients where i.Type == suit select i).First();
                Ingredients.Add((Ingredient)vv);
            }
        }

        /// <summary>
        /// Формирование текста рецепта
        /// </summary>
        /// <returns>текст рецепта</returns>
        public string Print()
        { 
            string recipeText = "Рецепт салата:";
            foreach (var ingredient in Ingredients)
            {
                recipeText += Environment.NewLine;
                recipeText += ingredient.ToString();
            }
            return recipeText;
        }
    }
}
