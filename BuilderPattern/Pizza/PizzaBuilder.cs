using BuilderPattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Pizza
{
    public class PizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public PizzaBuilder(PizzaType pizzaType)
        {
            pizza.PizzaType = pizzaType;
        }

        public void ExtraCheese(bool extraCheese)
        {
            pizza.ExtraCheese = extraCheese;
        }
        public void ExtraIngredient (ExtraIngredient extraIngredient)
        {
            pizza.ExtraIngredient = extraIngredient;
        }
        public void PizzaCrust (PizzaCrust pizzaCrust)
        {
            pizza.PizzaCrust = pizzaCrust;
        }

        public Pizza Build()
        {
            //we can Check Extra Cheese can't be added with Pizza Type Cheese
            if (pizza.PizzaType == PizzaType.Cheese && pizza.ExtraCheese)
                throw new InvalidOperationException("No Extra Cheese with Cheese");

            return pizza;
        }
        
    }
}
