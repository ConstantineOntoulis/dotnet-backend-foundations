using BookReviewApp.Data;
using BookReviewApp.Interfaces;
using BookReviewApp.Models;

namespace BookReviewApp.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Book> GetAllBooks()
        {
            return _context.Books.OrderBy( b=> b.Id ).ToList();
        }
    }
}
