using CafePizza.Pizzas;
using CafePizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza.Builders
{
    public abstract class AbstractPizzaBuilder
    {
        public AbstractPizza pizza;

        public virtual AbstractPizzaBuilder AddCheese()
        {
            //Console.WriteLine("Add cheese");
            pizza.cheese = new Cheese();
            return this;
        }

        public virtual AbstractPizzaBuilder AddTomatoes()
        {
            //Console.WriteLine("Add tomatoes");
            pizza.tomatoes = new Tomatoes();
            return this;
        }

        public virtual AbstractPizzaBuilder AddOlives()
        {
            //Console.WriteLine("Add olives");
            pizza.olives = new Olives();
            return this;
        }

        public virtual AbstractPizzaBuilder AddMeat()
        {
            //Console.WriteLine("Add meat");
            pizza.meat = new Meat();
            return this;
        }

        public abstract AbstractPizza Create();
    }
}
