using LibraryManagement.DTOs;

namespace LibraryManagement.Validators
{
    public class BookValidator
    {
        public static bool isValid(BookDTO book)
        {
            return !string.IsNullOrEmpty(book.Title) && // Title should not be empty
                !string.IsNullOrEmpty(book.ISBN) && // ISBN should not be empty
                !string.IsNullOrEmpty(book.Author) && // Author should not be empty
                book.Price > 0 && //price should be greater then 0
                book.AvailablesCopies >= 0; // available copies should be positive
        }
    }
}
