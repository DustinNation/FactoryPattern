using FactoryPattern.Ingredients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ingredients.Concrete
{
    class FreshClams : Clams
    {
        public FreshClams()
        {
            Name = "Fresh Clams";
        }
    }
}
