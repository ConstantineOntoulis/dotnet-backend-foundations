using Microsoft.EntityFrameworkCore;

namespace BookReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions) { }
    }
}
