using CafePizza.Builders;
using CafePizza.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza
{
    public class Cafe
    {
        public static AbstractPizza CreatePizza(string pizzaName)
        {
            AbstractPizzaBuilder pizzaBuilder;

            switch (pizzaName)
            {
                case "Margarita":
                    pizzaBuilder = new MargaritaBuilder();
                    break;

                case "Carbonara":
                    pizzaBuilder = new CarbonaraBuilder();
                    break;

                case "Italian":
                    pizzaBuilder = new ItalianBuilder();
                    break;

                case "Pepperoni":
                    pizzaBuilder = new PepperoniBuilder();
                    break;

                default:
                    throw new ArgumentException("Pizza with that name is not on our menu");
            }

            pizzaBuilder.AddCheese().AddTomatoes().AddOlives().AddMeat();

            return pizzaBuilder.Create();
        }
    }
}
