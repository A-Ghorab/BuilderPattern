using Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class PizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public PizzaBuilder(PizzaType pizzaType)
        {
            pizza.PizzaType = pizzaType;
        }

        public PizzaBuilder ExtraCheese(bool extraCheese)
        {
            pizza.ExtraCheese = extraCheese;
            return this;
        }
        public PizzaBuilder ExtraIngredient (ExtraIngredient extraIngredient)
        {
            pizza.ExtraIngredient = extraIngredient;
            return this;
        }
        public PizzaBuilder PizzaCrust (PizzaCrust pizzaCrust)
        {
            pizza.PizzaCrust = pizzaCrust;
            return this;
        }

        public Pizza Build()
        {
            //All Validation Go Here

            //we can Check Extra Cheese can't be added with Pizza Type Cheese
            if (pizza.PizzaType == PizzaType.Cheese && pizza.ExtraCheese)
                throw new InvalidOperationException("No Extra Cheese with Cheese");

            //Return Finished Pizza
            return new Pizza
            {
                PizzaType = pizza.PizzaType,
                ExtraCheese = pizza.ExtraCheese,
                ExtraIngredient = pizza.ExtraIngredient,
                PizzaCrust = pizza.PizzaCrust
            };
            
            
        }
        
    }
}
