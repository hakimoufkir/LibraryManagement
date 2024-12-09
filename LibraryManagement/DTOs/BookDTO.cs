namespace LibraryManagement.DTOs
{
    public class BookDTO
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int AvailablesCopies { get; set; }
    }
}
