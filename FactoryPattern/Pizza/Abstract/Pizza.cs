// See https://aka.ms/new-console-template for more information
using FactoryPattern.Ingredients.Abstract;

namespace FactoryPattern.AbstractPizza
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough dough { get; set; }
        public Sauce sauce { get; set; }
        public Veggies[] veggies { get; set; }
        public Cheese cheese { get; set; }
        public Pepperoni pepperoni { get; set; }
        public Clams clams { get; set; }


        public abstract void Prepare();

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
