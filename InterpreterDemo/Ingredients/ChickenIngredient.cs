namespace InterpreterDemo.Ingredients
{
    public class ChickenIngredient : IIngredient
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Chicken");
        }
    }
}