using CafePizza.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafePizza.Builders
{
    public class ItalianBuilder : AbstractPizzaBuilder
    {
        public ItalianBuilder()
        {
            pizza = new Italian();
        }

        public override AbstractPizza Create()
        {
            AbstractPizza result = pizza;
            pizza = new Italian();
            return result;
        }
    }
}
