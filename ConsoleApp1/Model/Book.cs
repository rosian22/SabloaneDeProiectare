using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book : Element
    {
        private Author author;
        private List<Element> content = new List<Element>();
        private string name;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public Book(string name)
        {
            this.name = name;
        }

        public void add(Element element)
        {
            this.content.Add(element);
        }

        public void remove(Element element)
        {
            this.content.Remove(element);
        }

        public Element getElement(int index)
        {
            return this.content[index];
        }

        public void print()
        {
            foreach (var element in content)
            {
                element.print();
            }
        }

        public Author getAuthor()
        {
            return author;
        }

        public void setAuthor(Author author)
        {
            this.author = author;
        }

        public void accept(Visitor visitor)
        {
            foreach (var element in content)
            {
                element.accept(visitor);
            }
            visitor.visit(this);
        }
    }

}
