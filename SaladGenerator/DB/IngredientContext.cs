using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SaladGenerator.Model;

namespace SaladGenerator.DB
{
    public class IngredientContext:DbContext
    {
        public IngredientContext():base("DbConnection")
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
