using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SaladGenerator.Model;

namespace SaladGeneratorTests
{
    [TestClass]
    public class BusinessLayerTests
    {
        [TestMethod]
        public void Recipe_from_6_ingredients()
        {
            //arrange
            int ingredientsCount = 6;
            List<Ingredient> ingredients = new List<Ingredient>();

            Ingredient ingr1 = new Ingredient();
            ingr1.Name = "Айсберг";
            ingr1.Type = IngredientTypes.BaseGreen;
            ingredients.Add(ingr1);

            Ingredient ingr11 = new Ingredient();
            ingr11.Name = "Шпинат";
            ingr11.Type = IngredientTypes.BaseGreen;
            ingredients.Add(ingr11);

            Ingredient ingr2 = new Ingredient();
            ingr2.Name = "Оливковое масло + сок лайма + сахар";
            ingr2.Type = IngredientTypes.Dressing;
            ingredients.Add(ingr2);

            Ingredient ingr3 = new Ingredient();
            ingr3.Name = "Базилик";
            ingr3.Type = IngredientTypes.Green;
            ingredients.Add(ingr3);

            Ingredient ingr4 = new Ingredient();
            ingr4.Name = "Красная рыба";
            ingr4.Type = IngredientTypes.Protein;
            ingredients.Add(ingr4);

            Ingredient ingr5 = new Ingredient();
            ingr5.Name = "Кунжут";
            ingr5.Type = IngredientTypes.Topping;
            ingredients.Add(ingr5);

            Ingredient ingr6 = new Ingredient();
            ingr6.Name = "Авокадо";
            ingr6.Type = IngredientTypes.Vegetable;
            ingredients.Add(ingr6);

            //act
            Recipe recipe = new Recipe(ingredients);
            //assert

            Assert.AreEqual(ingredientsCount, recipe.Ingredients.Count);
        }
    }
}
