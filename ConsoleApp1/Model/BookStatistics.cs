using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BookStatistics : Visitor
    {
        private int numberOfImageProxy = 0;
        private int numberOfParagraphs = 0;
        private int numberOfImages = 0;
        private int numberOfSections = 0;
        private int numberOfBooks = 0;
        private int numberOfTables = 0;

        public void visit(Image image)
        {
            numberOfImages++;
        }

        public void visit(ImageProxy imageProxy)
        {
            numberOfImageProxy++;
        }

        public void visit(Paragraph paragraph)
        {
            numberOfParagraphs++;
        }

        public void visit(Table table)
        {
            numberOfTables++;
        }

        public void visit(Book book)
        {
            numberOfBooks++;
        }

        public void printStatistics()
        {
            Console.WriteLine("Book Statistics:");
            Console.WriteLine("*** Number of images: " + numberOfImages);
            Console.WriteLine("*** Number of tables: " + numberOfTables);
            Console.WriteLine("*** Number of paragraphs: " + numberOfParagraphs);
            Console.WriteLine("*** Number of proxy images: " + numberOfImageProxy);
            Console.WriteLine("*** Number of sections: " + numberOfSections);
        }

        public void visit(Section section)
        {
            numberOfSections++;
        }
    }
}
