using CoffeCodeDevops.Data.Dto;
using CoffeCodeDevops.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoffeCodeDevops.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class FeedbackController : Controller
    {
        private readonly FeedbackRepository _feedbackRepository;

        public FeedbackController(FeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        [HttpGet("GetFeedbacks")]
        public async Task<IActionResult> GetFeedbacks()
        {
            var feedbacks = await _feedbackRepository.GetFeedbacksAsync();
            return Ok(feedbacks);
        }


        [HttpPost("CreateFeedback")]
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackDto feedback)
        {
            await _feedbackRepository.CreateFeedbackAsync(feedback);
            return Ok(feedback);
        }

        [HttpPost("CreateFeedbackList")]
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackDto[] feedbacks)
        {
            await _feedbackRepository.CreateFeedbackListAsync(feedbacks);
            return Ok(feedbacks);
        }
    }
}
