using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{

    //DELEGATES
    //Declare Delegate 
    delegate double BooksDelegate(double aParameter, double bParameter);
    delegate Book HighestPriceDelegate(double price);
    delegate List<Book> JustASortedList(List<Book> bookList);
    class BookLibrary
    {
        List<Book> books = new List<Book>();

        public List<Book> GetList()
        {

            return books;

        }

        public void Menu()
        {
            Console.WriteLine("Enter either 1, 2, 3, 4, 5, or 6");
            Console.WriteLine("1. Print only the soft cover books and their average price.");
            Console.WriteLine("2. Print the most expensive book.");
            Console.WriteLine("3. Sort the books by title.");
            Console.WriteLine("4. Enter a new book");
            Console.WriteLine("5. Print all books");
            Console.WriteLine("6. Exit the program");
            Console.WriteLine();
            int userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                double totalPriceOfAllBooks = 0;
                int countOfSoftCoverBooks = 0;
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].TypeOfCover.Equals("softcover", StringComparison.InvariantCultureIgnoreCase))
                    {
                        totalPriceOfAllBooks += books[i].Price;
                        countOfSoftCoverBooks++;
                        Console.WriteLine("Title: "+books[i].Title+ ", author: " +books[i].Author+ ", price: " +books[i].Price+ ", type of cover: " + books[i].TypeOfCover);
                        Console.WriteLine();
                    }
                }
                BooksDelegate bD = delegate (double count, double totalPrice)
                {
                    double avgPriceOfAllSoftCoverBooks;
                    return avgPriceOfAllSoftCoverBooks = totalPrice / count;
                };

                double avgPrice = bD(countOfSoftCoverBooks, totalPriceOfAllBooks);
                Console.WriteLine("Average of all soft cover books: ${0}", avgPrice);

                Console.WriteLine();
                Console.WriteLine();
                Menu();
            }
            else if (userResponse == 2)
            {
                HighestPriceDelegate hP = delegate (double price)
                {
                    Book highestPricedBook= null;
                    
                    for (int i = 0; i < books.Count; i++)
                    {
                        if(price == books[i].Price)
                        {
                            highestPricedBook = books[i];
                        }
                    }
                    return highestPricedBook;
                };

                Book mostExpensiveBook = hP(books.Max(b => b.Price));
                Console.WriteLine("The Most Expensive book is: "+ mostExpensiveBook.Title + ", by: " + mostExpensiveBook.Author + ", price: " + mostExpensiveBook.Price + ", type of cover: " + mostExpensiveBook.TypeOfCover);

                Console.WriteLine();
                Console.WriteLine();
                Menu();

            }
            else if (userResponse == 3)
            {
                Console.WriteLine("Sorting the books by title: ");
                Console.WriteLine();

                JustASortedList sL = sortBooksByTitle;

                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine(sortBooksByTitle(books)[i].Title);
                }

                Console.WriteLine();
                Console.WriteLine();

                Menu();
                
            }
            else if (userResponse == 4)
            {
                EnterNewBook();
            }
            else if (userResponse == 5)
            {
                PrintAllBooks();
            }
            else if (userResponse == 6)
            {
                Environment.Exit(0);
            }
        }

        public void EnterNewBook()
        {
            Console.WriteLine("You have selected to add a new book");
            Console.WriteLine();
            Console.WriteLine("What is the title? ");
            string title = Console.ReadLine();
            Console.WriteLine("What is the authors name? ");
            string author = Console.ReadLine();
            Console.WriteLine("What is the price? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the type of cover? ");
            string typeOfCover = Console.ReadLine();

            Book newBook = new Book(title,author,price,typeOfCover);
            books.Add(newBook);

            Menu();
        }

        public void PrintAllBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i].Title + " by: "  + books[i].Author + ", price: " + books[i].Price + ", type of cover: " + books[i].TypeOfCover);
                Console.WriteLine();
            }
            Menu();
        }

        public void LoadInitialSetOfBooks()
        {
            Book harryPotter = new Book("Harry Potter", "J.K. Rowling", 25, "SoftCover");
            Book nightAngel = new Book("The Black Prism", "Brent Weeks", 20, "SoftCover");
            Book eragon = new Book("Eragon", "Christopher Paolini", 30, "HardCover");
            Book codeComplete = new Book("Code Complete", "McConnell", 35, "HardCover");
            Book dotComSecrets = new Book("Dot Com Secrets", "Russell Brunson", 15, "SoftCover");

            books.Add(harryPotter);
            books.Add(nightAngel);
            books.Add(eragon);
            books.Add(codeComplete);
            books.Add(dotComSecrets);
        }

        public List<Book> sortBooksByTitle(List<Book> booksListParameter)
        {
            return books = books.OrderBy(o => o.Title).ToList();
        }
    }
}
