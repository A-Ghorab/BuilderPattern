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
            PizzaBuilder.ExtraCheese(true)
                        .ExtraIngredient(Enums.ExtraIngredient.Meat)
                        .PizzaCrust(Enums.PizzaCrust.Normal);

   

            Console.WriteLine(PizzaBuilder.Build());
        }
    }
}
