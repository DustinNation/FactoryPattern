using FactoryPattern.Ingredients.Abstract;

namespace FactoryPattern.Ingredients.Concrete
{
    class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public Clams CreateClams()
        {
            throw new NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
