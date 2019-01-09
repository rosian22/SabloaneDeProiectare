using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ImageProxy : Element
    {
        private string imageName;
        Image image = null;

        public ImageProxy(string imageName)
        {
            this.imageName = imageName;
        }

        public void print()
        {
            if (this.image == null)
            {
                this.image = new Image(this.imageName);
            }
            this.image.print();
        }

        public void add(Element element)
        {
            Console.WriteLine("ERORR - IMG PROXY");
        }

        public void remove(Element element)
        {
            Console.WriteLine("ERORR - IMG PROXY");
        }

        public Element getElement(int index)
        {
            Console.WriteLine("ERORR - IMG PROXY");
            return null;
        }

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }

}
