using FactoryPattern.AbstractPizza;

namespace FactoryPattern.PizzaTypes
{
    internal class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            name = "NY-Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
