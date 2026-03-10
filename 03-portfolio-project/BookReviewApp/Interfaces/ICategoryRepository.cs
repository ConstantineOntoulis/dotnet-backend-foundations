using BookReviewApp.Models;

namespace BookReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int categoryId);
        ICollection<Book> GetBooksByCategory(int categoryId);
        bool CategoryExists(int categoryId);
    }
}
