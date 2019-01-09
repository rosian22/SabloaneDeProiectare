using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Command
{
    public class OpenCommand : Command
    {

        public void execute()
        {
            var json = "";
            Book jsonBook = null;

            using (StreamReader r = new StreamReader("book.json"))
            {
                json = r.ReadToEnd();
                jsonBook = JsonConvert.DeserializeObject<Book>(json);
            }
            Book book = new Book("carte1");
            book.add(jsonBook);
            DocumentManager.getInstance().setBook(book);
            book.print();
        }

    }


}
