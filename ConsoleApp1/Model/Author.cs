using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Author
    {
        private string name;

        public Author(string name)
        {
            this.name = name;
        }

        public void print()
        {
            Console.WriteLine("Author: " + name);
        }
    }

}
