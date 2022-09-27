using FactoryPattern.Ingredients.Abstract;

namespace FactoryPattern.Ingredients
{
    internal interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClams();
    }
}
