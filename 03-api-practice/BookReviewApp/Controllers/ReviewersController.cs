using BookReviewApp.Dto;
using BookReviewApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReviewersController : ControllerBase
    {
        private readonly IReviewerRepository _reviewerRepository;
        public ReviewersController(IReviewerRepository reviewerRepository)
        {
            _reviewerRepository = reviewerRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReviewerDto>))]
        public IActionResult GetReviewers()
        {
            var reviewers = _reviewerRepository.GetReviewers()
                .Select(r => new ReviewerDto
                {
                    Id = r.Id,
                    FirstName = r.FirstName,
                    LastName = r.LastName
                });
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(reviewers);
        }

        [HttpGet("{reviewerId}")]
        [ProducesResponseType(200, Type = typeof(ReviewerDto))]
        [ProducesResponseType(400)]
        public IActionResult GetReviewer(int reviewerId)
        {
            if (!_reviewerRepository.ReviewerExists(reviewerId))
            {
                return BadRequest("Reviewer not found.");
            }
            var reviewer = _reviewerRepository.GetReviewer(reviewerId);
            var reviewerDto = new ReviewerDto
            {
                Id = reviewer.Id,
                FirstName = reviewer.FirstName,
                LastName = reviewer.LastName
            };
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(reviewerDto);
        }

        [HttpGet("{reviewerId}/reviews")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReviewDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetReviewsByReviewer(int reviewerId)
        {
            if (!_reviewerRepository.ReviewerExists(reviewerId))
            {
                return BadRequest("Reviewer not found.");
            }
            var reviews = _reviewerRepository.GetReviewsByReviewer(reviewerId)
                .Select(r => new ReviewDto
                {
                    Id = r.Id,
                    Title = r.Title,
                    Text = r.Text,
                    Rating = r.Rating
                });
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(reviews);
        }
    }
}