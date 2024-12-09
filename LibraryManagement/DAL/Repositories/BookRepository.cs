using LibraryManagement.Models;

namespace LibraryManagement.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
            Data.Books.Add(book);
        }

        public void DeleteBook(string ISBN)
        {
            Data.Books.RemoveAll(x => x.ISBN == ISBN);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return Data.Books;
        }

        public Book GetBookById(string ISBN)
        {
            return Data.Books.FirstOrDefault(b => b.ISBN == ISBN);
        }

        public void UpdateBook(Book book)
        {
            Book bookInData = GetBookById(book.ISBN);
            if (bookInData != null)
            {
                bookInData.Price = book.Price;
                bookInData.Author = book.Author;
                bookInData.Title = book.Title;
                bookInData.AvailablesCopies = book.AvailablesCopies;
            }
        }
    }
}
