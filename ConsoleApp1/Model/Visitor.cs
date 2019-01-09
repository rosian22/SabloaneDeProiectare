using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Visitor
    {
         void visit(Image image);

         void visit(ImageProxy imageProxy);

         void visit(Paragraph paragraph);

         void visit(Table table);

         void visit(Book book);

         void visit(Section section);
    }

}
