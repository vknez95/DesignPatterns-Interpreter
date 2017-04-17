using System.Collections.Generic;
using InterpreterDemo.Ingredients;

namespace InterpreterDemo
{
    public class IngredientList : IExpression
    {
        private readonly List<IIngredient> ingredients;

        public IngredientList(List<IIngredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach(var ingredient in ingredients)
                ingredient.Interpret(context);
        }
    }
}