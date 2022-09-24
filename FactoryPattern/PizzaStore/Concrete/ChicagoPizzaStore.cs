using FactoryPattern.AbstractPizza;
using FactoryPattern.PizzaTypes;

namespace FactoryPattern.PizzaStore
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }

            return null;
        }
    }
}
