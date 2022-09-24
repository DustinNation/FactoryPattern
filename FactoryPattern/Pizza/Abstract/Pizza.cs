// See https://aka.ms/new-console-template for more information
namespace FactoryPattern.AbstractPizza
{
    public abstract class Pizza
    {
        public string name = string.Empty;
        public string dough = string.Empty;
        public string sauce = string.Empty;
        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine(string.Format("Preparing {0}", name));
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var topping in toppings)
            {
                Console.WriteLine("     {0}", topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place the pizza in an official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }
    }
}
