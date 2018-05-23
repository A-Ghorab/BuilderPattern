using Pizza;
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

            var pizza = PizzaBuilder.Build();
            //Modifing the Prop will Throw error so it's now only accessable from Builder For full Control
            //pizza.PizzaCrust = Enums.PizzaCrust.Normal;

            Console.WriteLine(pizza);
        }
    }
}
