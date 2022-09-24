// See https://aka.ms/new-console-template for more information

using FactoryPattern.AbstractPizza;
using FactoryPattern.PizzaStore;

PizzaStore newYorkStore = new NyPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = newYorkStore.OrderPizza("cheese");
Console.WriteLine(string.Format("Ethan ordered a {0}",pizza.GetName()));
Console.WriteLine();

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine(string.Format("Joel ordered a {0}", pizza.GetName()));
Console.WriteLine();
