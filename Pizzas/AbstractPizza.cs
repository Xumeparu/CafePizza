using CafePizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza.Pizzas
{
    public abstract class AbstractPizza
    {
        protected string Name { get; set; }

        public Cheese cheese { get; set; } = null;
        public Tomatoes tomatoes { get; set; } = null;
        public Olives olives { get; set; } = null;
        public Meat meat { get; set; } = null;

        public string GetPizzaComposition()
        {
            string ingredients = "";

            if (cheese != null)
            {
                ingredients += $"\n- {cheese.GetType().Name.ToLower()}";
            }

            if (tomatoes != null)
            {
                ingredients += $"\n- {tomatoes.GetType().Name.ToLower()}";
            }

            if (olives != null)
            {
                ingredients += $"\n- {olives.GetType().Name.ToLower()}";
            }

            if (meat != null)
            {
                ingredients += $"\n- {meat.GetType().Name.ToLower()}";
            }

            return $"Your pizza:" +
                   $"\n- {Name}" + 
                   $"\n\nComposition:" + 
                   $"{ingredients}";
        }
    }
}
