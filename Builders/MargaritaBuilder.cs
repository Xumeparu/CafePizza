using CafePizza.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza.Builders
{
    public class MargaritaBuilder : AbstractPizzaBuilder
    {
        public MargaritaBuilder()
        {
            pizza = new Margarita();
        }

        public override AbstractPizzaBuilder AddMeat()
        {
            //Console.WriteLine("Meat cannot be added to Margarita");
            return this;
        }

        public override AbstractPizza Create()
        {
            AbstractPizza result = pizza;
            pizza = new Margarita();
            pizza.GetPizzaComposition();
            return result;
        }
    }
}
