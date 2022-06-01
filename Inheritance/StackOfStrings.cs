using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StackOfStrings:Stack<String>
    {
        
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
                this.Push(element);
        }

    }
}
