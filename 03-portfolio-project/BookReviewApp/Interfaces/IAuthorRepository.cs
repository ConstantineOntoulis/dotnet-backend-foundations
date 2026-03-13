using BookReviewApp.Models;

namespace BookReviewApp.Interfaces
{
    public interface IAuthorRepository
    {
        ICollection<Author> GetAllAuthors();
        Author GetAuthorById(int AuthorId);
        ICollection<Author> GetAuthorOfBooks(int bookId);
        ICollection<Book> GetBooksByAuthor(int authorId);
        bool AuthorExists(int authorId);
    }
}
