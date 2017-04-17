namespace InterpreterDemo.Ingredients
{
    public class MushroomIngredient : IIngredient
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Mushroom");
        }
    }
}