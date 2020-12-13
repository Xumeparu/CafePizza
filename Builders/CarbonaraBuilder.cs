using CafePizza.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza.Builders
{
    public class CarbonaraBuilder : AbstractPizzaBuilder
    {
        public CarbonaraBuilder()
        {
            pizza = new Carbonara();
        }

        public override AbstractPizzaBuilder AddOlives()
        {
            //Console.WriteLine("Olives cannot be added to Carbonara");
            return this;
        }

        public override AbstractPizza Create()
        {
            AbstractPizza result = pizza;
            pizza = new Carbonara();
            return result;
        }
    }
}
