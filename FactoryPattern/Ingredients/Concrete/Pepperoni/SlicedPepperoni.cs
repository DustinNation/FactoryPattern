using FactoryPattern.Ingredients.Abstract;

namespace FactoryPattern.Ingredients.Concrete
{
    internal class SlicedPepperoni : Pepperoni
    {
        public SlicedPepperoni()
        {
            Name = "Sliced Pepperoni";
        }
    }
}
