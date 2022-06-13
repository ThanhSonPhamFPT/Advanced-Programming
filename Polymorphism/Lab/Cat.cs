using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
    : base(name, favouriteFood) { }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEOW";
        }
    }
}
