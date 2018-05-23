using BuilderPattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Pizza
    {
        public Pizza(PizzaType pizzaType)
        {
            PizzaType = pizzaType;
        }

        public PizzaType PizzaType { get; set; }
        public bool ExtraCheese { get; set; }
        public ExtraIngredient? ExtraIngredient { get; set; }
        public PizzaCrust PizzaCrust { get; set; }

        public override string ToString()
        {
            return $@"Pizza Type :{PizzaType} with {(ExtraCheese ? "Extra Cheese" : "No Extra Cheese")} , 
                    Has Extra Ingerdient {(ExtraIngredient.HasValue? ExtraIngredient.ToString() : "No")} 
                    and Pizza Crust is {PizzaCrust} ";
        }

    }
}
