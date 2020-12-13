using CafePizza.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza.Builders
{
    public class PepperoniBuilder : AbstractPizzaBuilder
    {
        public PepperoniBuilder()
        {
            pizza = new Pepperoni();
        }

        public override AbstractPizzaBuilder AddOlives()
        {
            //Console.WriteLine("Olives cannot be added to Pepperoni");
            return this;
        }

        public override AbstractPizza Create()
        {
            AbstractPizza result = pizza;
            pizza = new Pepperoni();
            return result;
        }
    }
}
