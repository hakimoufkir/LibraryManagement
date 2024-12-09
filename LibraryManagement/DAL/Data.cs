using LibraryManagement.Models;

namespace LibraryManagement.DAL
{
    public class Data
    {
        public static List<Book> Books = new List<Book>
        {
        new Book { Title = "The Great Gatsby", ISBN = "9780743273565", Price = 25.99, Author = "F. Scott Fitzgerald" },
        new Book { Title = "To Kill a Mockingbird", ISBN = "0061120081", Price = 19.99, Author = "Harper Lee" },
        new Book { Title = "1984", ISBN = "9780451524935", Price = 12.50, Author = "George Orwell" },
        new Book { Title = "The Catcher in the Rye", ISBN = "9780241950425", Price = 15.75, Author = "J.D. Salinger" },
        new Book { Title = "The Hobbit", ISBN = "9780547928227", Price = 22.95, Author = "J.R.R. Tolkien" }
        };
    }

  
}

