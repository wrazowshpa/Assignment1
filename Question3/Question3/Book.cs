using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public double Price { get; private set; }
        public string TypeOfCover { get; private set; }
        
        public Book()
        {

        }

        public Book(string title, string author, double price, string typeOfCover)
        {
            Title = title;
            Author = author;
            Price = price;
            TypeOfCover = typeOfCover;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
