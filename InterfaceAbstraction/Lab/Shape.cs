using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    abstract class Shape 
    {
        public abstract void Print();
        public virtual void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
