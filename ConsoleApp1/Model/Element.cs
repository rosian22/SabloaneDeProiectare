using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Element
    {
        void add(Element element);

        void remove(Element element);

        Element getElement(int index);

        void print();

        void accept(Visitor visitor);

    }

}
