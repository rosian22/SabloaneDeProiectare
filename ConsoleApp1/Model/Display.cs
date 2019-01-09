using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Display : Visitor
    {
        private string imageMessages = "";
        private string paragraphMessages = "";

        public void visit(Image image)
        {
            image.print();
        }

        public void visit(ImageProxy imageProxy)
        {
        }

        public void visit(Paragraph paragraph)
        {
            paragraph.print();
        }

        public void visit(Table table)
        {
        }

        public void visit(Book book)
        {
        }

        public void printStatistics()
        {
            Console.WriteLine("Book Statistics:");
        }

        public void visit(Section section)
        {
        }

        public string getImageMessages()
        {
            return imageMessages;
        }

        public void setImageMessages(string imageMessages)
        {
            this.imageMessages = imageMessages;
        }

        public String getParagraphMessages()
        {
            return paragraphMessages;
        }

        public void setParagraphMessages(string paragraphMessages)
        {
            this.paragraphMessages = paragraphMessages;
        }

    }

}
