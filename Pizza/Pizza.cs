using Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Pizza
    {
        protected internal Pizza()
        {

        }
        public PizzaType PizzaType { get; protected internal set; }
        public bool ExtraCheese { get; protected internal set; }
        public ExtraIngredient ExtraIngredient { get; protected internal set; }
        public PizzaCrust PizzaCrust { get; protected internal set; }

        public override string ToString()
        {
            return $@"Pizza Type :{PizzaType} with {(ExtraCheese ? "Extra Cheese" : "No Extra Cheese")} , 
                    Has Extra Ingerdient {(ExtraIngredient != ExtraIngredient.None? ExtraIngredient.ToString() : "No")} 
                    and Pizza Crust is {PizzaCrust} ";
        }

    }
}
