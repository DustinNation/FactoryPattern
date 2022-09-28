using FactoryPattern.AbstractPizza;
using FactoryPattern.Ingredients.Concrete;
using FactoryPattern.Ingredients.Interface;
using FactoryPattern.Pizzas;
using FactoryPattern.PizzaTypes;

namespace FactoryPattern.PizzaStore
{
    public class NyPizzaStore : PizzaStore
    {
        public Pizza Pizza { get; set; }
        private IPizzaIngredientFactory _ingredientFactory = new NyPizzaIngredientFactory();

        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    Pizza = new CheesePizza(_ingredientFactory) { Name = "New York Style Cheese Pizza" };
                    break;
                case "clam":
                    Pizza = new ClamPizza(_ingredientFactory) { Name = "New York Syle Clam Pizza" };
                    break;
                case "pepperoni":
                    Pizza = new PepperoniPizza(_ingredientFactory) { Name = "New York Style Pepperoni Pizza" };
                    break;
                case "veggie":
                    Pizza = new VeggiePizza(_ingredientFactory) { Name = "New York Style Veggie Pizza" };
                    break;
                default:
                    break;
            }
        }
    }
}