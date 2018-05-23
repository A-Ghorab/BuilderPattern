using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lets clean the Code a little bit 

            Pizza pizza = new Pizza(Enums.PizzaType.Meat)
            {
                ExtraCheese = true,
                ExtraIngredient = Enums.ExtraIngredient.Peperoni,
                PizzaCrust = Enums.PizzaCrust.Stuffed
            };

            Console.WriteLine(pizza);
        }
    }
}
