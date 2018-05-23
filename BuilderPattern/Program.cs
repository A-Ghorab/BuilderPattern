using BuilderPattern.Pizza;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lets clean the Code a little bit 
            var PizzaBuilder = new PizzaBuilder(Enums.PizzaType.Meat);
            PizzaBuilder.ExtraCheese(true);
            PizzaBuilder.ExtraIngredient(Enums.ExtraIngredient.Meat);
            PizzaBuilder.PizzaCrust(Enums.PizzaCrust.Normal);

   

            Console.WriteLine(PizzaBuilder.Build());
        }
    }
}
