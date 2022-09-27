using FactoryPattern.Ingredients.Abstract;

namespace FactoryPattern.Ingredients.Concrete
{
    class ThinCrustDough : Dough
    {
        public ThinCrustDough()
        {
            Name = "Thin Crust Dough";
        }
    }
}
