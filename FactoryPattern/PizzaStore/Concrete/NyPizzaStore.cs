using FactoryPattern.AbstractPizza;
using FactoryPattern.PizzaTypes;

namespace FactoryPattern.PizzaStore
{
    internal class NyPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NyStyleCheesePizza();
            }
         
            return null;
        }
    }
}