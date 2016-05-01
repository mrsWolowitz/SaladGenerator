using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladGenerator.Model
{
    public class Ingredient
    {
        /// <summary>
        /// Наименование ингредиента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип ингредиента
        /// </summary>
        public IngredientTypes Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
        
    }
}
