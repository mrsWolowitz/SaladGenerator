using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladGenerator.Model
{
    class Ingredient
    {
        /// <summary>
        /// Наименование ингридиента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип ингридиента
        /// </summary>
        public IngredientTypes Type { get; set; }
        
    }
}
