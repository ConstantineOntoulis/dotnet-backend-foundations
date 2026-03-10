using BookReviewApp.Models;

namespace BookReviewApp.Interfaces
{
    public interface IBookRepository
    {
        ICollection<Book> GetAllBooks();
        Book GetBook(int id);
        Book GetBookById(int id);
        decimal GetBookRating(int bookId);
        bool BookExists(int bookId);
    }
}
