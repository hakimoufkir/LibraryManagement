using LibraryManagement.DAL.Repositories;
using LibraryManagement.DTOs;
using LibraryManagement.Exceptions;
using LibraryManagement.Models;
using LibraryManagement.Validators;

namespace LibraryManagement.Services
{    
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public void AddBook(BookDTO bookDTO)
        {
            if (!BookValidator.isValid(bookDTO))
            {
                throw new InvalidBookException("Book's data is invalid");
            }

            Book book = new Book
            {
                Title = bookDTO.Title,
                Author = bookDTO.Author,
                ISBN = bookDTO.ISBN,
                Price = bookDTO.Price,
                AvailablesCopies = bookDTO.AvailablesCopies
            };

            _repository.AddBook(book);
        }

        public void DeleteBookById(string ISBN)
        {
           Book deleteBook = _repository.GetBookById(ISBN);
            if (deleteBook is null)
            {
                throw new BookNotFoundException(ISBN);
            }
            _repository.DeleteBook(ISBN);

        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            return _repository.GetAllBooks().Select(book => new BookDTO
            {
                ISBN = book.ISBN,
                Title = book.Title,
                Author = book.Author,
                Price = book.Price,
                AvailablesCopies = book.AvailablesCopies
            });
        }

        public BookDTO GetBookById(string ISBN)
        {
            Book book = _repository.GetBookById(ISBN);
            if (book == null)
            {
                throw new BookNotFoundException(ISBN);
            }
            return new BookDTO
            {
                Title = book.Title,
                ISBN = book.ISBN,
                Author = book.Author,
                Price = book.Price,
                AvailablesCopies = book.AvailablesCopies
            };
        }

        public void UpdateBook(string ISBN , BookDTO book)
        {
            Book oneBook = _repository.GetBookById(ISBN);
            if (oneBook == null)
            {
                throw new BookNotFoundException(ISBN);
            }
            if (!BookValidator.isValid(book))
            {
                throw new InvalidBookException("Book's data is invalid");
            }
            oneBook.Title = book.Title;
            oneBook.ISBN = book.ISBN;
            oneBook.Author = book.Author;
            oneBook.AvailablesCopies = book.AvailablesCopies;
            oneBook.Price = book.Price;

            _repository.UpdateBook(oneBook);

        }
    }
}
