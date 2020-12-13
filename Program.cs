using CafePizza.Builders;
using CafePizza.Pizzas;
using System;

namespace CafePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose pizza: Margarita, Carbonara, Italian or Pepperoni\n");
            var pizza = Console.ReadLine();

            AbstractPizza abstractPizza = Cafe.CreatePizza(pizza);
            Console.WriteLine("\n" + abstractPizza.GetPizzaComposition());

            /*AbstractPizzaBuilder margaritaBuilder = new MargaritaBuilder();
            margaritaBuilder.AddCheese().AddTomatoes().AddOlives().AddMeat();

            AbstractPizza pizza1 = margaritaBuilder.Create();
            Console.WriteLine("\n" + pizza1.GetPizzaComposition());

            margaritaBuilder.AddCheese().AddMeat();

            AbstractPizza pizza2 = margaritaBuilder.Create();
            Console.WriteLine("\n" + pizza2.GetPizzaComposition());*/

            Console.ReadKey();
        }
    }
}
