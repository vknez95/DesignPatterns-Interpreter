namespace InterpreterDemo.Condiments
{
    public class MustardCondiment : ICondiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Mustard");
        }
    }
}