using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Book
    {
        string Title;
        string Author;

        public Book()
        {    
        }

        public Book(string title)
        {
            Title = title;
        }
        public Book(string title, string author) {
            Title = title;
            Author = author;
        }
    }
}
