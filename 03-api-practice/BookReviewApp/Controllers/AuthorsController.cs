using BookReviewApp.Dto;
using BookReviewApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AuthorDto>))]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAllAuthors().Select(a => new AuthorDto
            {
                Id = a.Id,
                Name = a.Name,
                Bio = a.Bio,
            }
            );
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(authors);
        }

        [HttpGet("{authorId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AuthorDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetAuthor(int authorId)
        {
            if (!_authorRepository.AuthorExists(authorId))
                return BadRequest("Author not found.");

            var author = _authorRepository.GetAuthorById(authorId);
            var authorDto = new AuthorDto
            {
                Id = author.Id,
                Name = author.Name,
                Bio = author.Bio,
            };

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(author);
        }

        [HttpGet("book/{bookId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AuthorDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetAuthorOfABook(int bookId)
        {
            var author = _authorRepository.GetAuthorOfBook(bookId).Select(a => new AuthorDto
            {
                Id = a.Id,
                Name = a.Name,
                Bio = a.Bio,
            });

            if (author == null)
                return NotFound("Book not found or has no author assigned");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(author);
        }

        [HttpGet("{authorId}/books")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BookDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetBooksByAuthor(int authorId)
        {
            if (!_authorRepository.AuthorExists(authorId))
                return BadRequest("Author not found.");

            var books = _authorRepository.GetBooksByAuthor(authorId).Select(a => new BookDto
            {
                Id = a.Id,
                Title = a.Title,
                ReleaseDate = a.ReleaseDate,

            });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(books);
        }
    }
}