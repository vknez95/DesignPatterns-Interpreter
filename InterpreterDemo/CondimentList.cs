using System.Collections.Generic;
using InterpreterDemo.Condiments;

namespace InterpreterDemo
{
    public class CondimentList : IExpression
    {
        private readonly List<ICondiment> condiments;

        public CondimentList(List<ICondiment> condiments )
        {
            this.condiments = condiments;
        }

        public void Interpret(Context context)
        {
            foreach(var condiment in condiments)
                condiment.Interpret(context);
        }
    }
}