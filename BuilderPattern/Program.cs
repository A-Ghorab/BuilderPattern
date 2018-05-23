using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Pizza(Enums.PizzaType.Meat, true, Enums.ExtraIngredient.Peperoni, Enums.PizzaCrust.Stuffed));
        }
    }
}
