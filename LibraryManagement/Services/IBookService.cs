using LibraryManagement.DTOs;

namespace LibraryManagement.Services
{
    public interface IBookService
    {
        IEnumerable<BookDTO> GetAllBooks();
        BookDTO GetBookById(string ISBN);
        void AddBook(BookDTO book);
        void DeleteBookById(string ISBN);
        void UpdateBook(string ISBN, BookDTO book);
    }
}
