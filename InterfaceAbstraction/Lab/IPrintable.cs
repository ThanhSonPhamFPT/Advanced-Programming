using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    internal interface IPrintable
    {
        void Print();
        void Document()=>Console.WriteLine("Print");
    }
}
