using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Paragraph : Element
    {
        private string text;

        public Paragraph(string text)
        {
            this.text = text;
        }

        public void print()
        {
            Console.WriteLine(text);
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
