using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //call booklibrary class
            BookLibrary bookLibrary = new BookLibrary();

            

            //load initial set of books
            bookLibrary.LoadInitialSetOfBooks();


            //assign the list from booklibrary
            List<Book> booksList = bookLibrary.GetList();


            //load the menu
            bookLibrary.Menu();
           

            

            Console.ReadLine();
        }
    }
}
