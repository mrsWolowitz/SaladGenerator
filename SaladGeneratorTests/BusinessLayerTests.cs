using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using SaladGenerator.Model;

namespace SaladGeneratorTests
{
    [TestClass]
    public class BusinessLayerTests
    {
        public List<Ingredient> Ingredients { set; get; }

        [TestInitialize]
        public void TestInitialize()
        {
            Ingredients = new List<Ingredient>();

            Ingredient ingr1 = new Ingredient();
            ingr1.Name = "Айсберг";
            ingr1.Type = IngredientTypes.BaseGreen;
            Ingredients.Add(ingr1);

            Ingredient ingr2 = new Ingredient();
            ingr2.Name = "Оливковое масло + сок лайма + сахар";
            ingr2.Type = IngredientTypes.Dressing;
            Ingredients.Add(ingr2);

            Ingredient ingr3 = new Ingredient();
            ingr3.Name = "Базилик";
            ingr3.Type = IngredientTypes.Green;
            Ingredients.Add(ingr3);

            Ingredient ingr4 = new Ingredient();
            ingr4.Name = "Красная рыба";
            ingr4.Type = IngredientTypes.Protein;
            Ingredients.Add(ingr4);

            Ingredient ingr5 = new Ingredient();
            ingr5.Name = "Кунжут";
            ingr5.Type = IngredientTypes.Topping;
            Ingredients.Add(ingr5);

            Ingredient ingr6 = new Ingredient();
            ingr6.Name = "Авокадо";
            ingr6.Type = IngredientTypes.Vegetable;
            Ingredients .Add(ingr6);
        }

        [TestMethod]
        public void Output_Count_ingredients()
        {
            //arrange
            int ingredientsCount = Ingredients.Count;

            Ingredient ingr = new Ingredient();
            ingr.Name = "Шпинат";
            ingr.Type = IngredientTypes.BaseGreen;
            Ingredients.Add(ingr);            

            //act
            Recipe recipe = new Recipe(Ingredients);
            
            //assert
            Assert.AreEqual(ingredientsCount, recipe.Ingredients.Count);
        }

        [TestMethod]
        public void Print()
        { 
            //arrange
            string recipeText = "Рецепт салата:"
                + Environment.NewLine
                + "Айсберг"
                + Environment.NewLine
                + "Красная рыба"
                + Environment.NewLine
                + "Авокадо"
                + Environment.NewLine
                + "Кунжут" 
                + Environment.NewLine
                + "Базилик" 
                + Environment.NewLine
                + "Оливковое масло + сок лайма + сахар";

            //act
            Recipe recipe = new Recipe(Ingredients);
            string result = recipe.Print();

            //assert
            Assert.AreEqual(recipeText, result);
        }
    }
}
