using LibraryManagement.Models;

namespace LibraryManagement.DAL.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(string ISBN);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(string ISBN);

    }
}
