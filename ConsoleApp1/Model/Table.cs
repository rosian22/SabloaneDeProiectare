using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Table : Element
    {
        private string title;

        public Table(String title)
        {
            this.title = title;
        }

        public void print()
        {
            Console.WriteLine(title);
        }

        public void add(Element element)
        {
            Console.WriteLine("ERORR");
        }

        public void remove(Element element)
        {
            Console.WriteLine("ERORR");
        }

        public Element getElement(int index)
        {
            Console.WriteLine("ERORR");
            return null;
        }

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }

    }

}
