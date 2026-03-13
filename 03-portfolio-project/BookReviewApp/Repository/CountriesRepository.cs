using BookReviewApp.Data;
using BookReviewApp.Interfaces;
using BookReviewApp.Models;

namespace BookReviewApp.Repository
{
    public class CountriesRepository : ICountryRepository
    {
        private readonly DataContext _context;
        public CountriesRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Country> GetCountries()
        {
            return _context.Countries.OrderBy(c => c.Id).ToList();
        }
        public Country GetCountry(int countryId)
        {
            return _context.Countries.Where(c => c.Id == countryId).FirstOrDefault();
        }
        public Country GetCountryByAuthor(int authorId)
        {
            var author = _context.Authors.Where(a => a.Id == authorId).FirstOrDefault();
            if (author == null)
                return null;
            return _context.Countries.Where(c => c.Id == author.Country.Id).FirstOrDefault();
        }
        public bool CountryExists(int countryId)
        {
            return _context.Countries.Any(c => c.Id == countryId);
        }
        public ICollection<Author> GetAuthorsFromCountry(int countryId)
        {
            return _context.Authors.Where(a => a.Country.Id == countryId).ToList();
        }
    }
}
