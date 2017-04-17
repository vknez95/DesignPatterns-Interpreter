using System;
using System.Collections.Generic;
using InterpreterDemo.Breads;
using InterpreterDemo.Condiments;
using InterpreterDemo.Ingredients;

namespace InterpreterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwhich = new Sandwhich(
                new WheatBread(),
                new CondimentList(
                    new List<ICondiment> { new MayoCondiment(), new MustardCondiment() }),
                new IngredientList(
                    new List<IIngredient> { new LettuceIngredient(), new ChickenIngredient(),
                                            new MushroomIngredient() }),
                new CondimentList(new List<ICondiment> { new KetchupCondiment() }),
                new WheatBread());

            sandwhich.Interpret(new Context());


            Console.ReadKey();
        }
    }
}
