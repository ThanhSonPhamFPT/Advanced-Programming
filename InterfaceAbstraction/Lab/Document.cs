using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    internal class Document : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }
    }
}
