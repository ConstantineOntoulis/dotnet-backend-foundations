using BookReviewApp.Models;

namespace BookReviewApp.Interfaces
{
    public interface IBookRepository
    {
        ICollection<Book> GetAllBooks();
    }
}
