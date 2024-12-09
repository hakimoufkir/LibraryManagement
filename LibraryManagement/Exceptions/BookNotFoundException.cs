namespace LibraryManagement.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string ISBN) : base($"Le livre avec l'id ${ISBN} n'a pas ete trouve")
        {

        }
    }
}
