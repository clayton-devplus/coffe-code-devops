using CoffeCodeDevops.Data.Dto;
using CoffeCodeDevops.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeCodeDevops.Data.Repository
{
    public class FeedbackRepository
    {
        private readonly DBDataContext _context;

        public FeedbackRepository(DBDataContext context)
        {
            _context = context;
        }
        public async Task CreateFeedbackAsync(FeedbackDto feedback)
        {
            var feed = new FeedbackModel()
            {
                FeedbackId = Guid.NewGuid(),
                NextWorkshop = feedback.NextWorkshop,
                PresentationNote = feedback.PresentationNote,
                SpeakerNote = feedback.SpeakerNote,
                Feedback = feedback.Feedback
            };

            _context.Feedbacks.Add(feed);
            await _context.SaveChangesAsync();
        }
        public async Task<List<FeedbackModel>> GetFeedbacksAsync()
        {
            var feedbacks = await _context.Feedbacks.ToListAsync();
            return feedbacks;
        }
    }
}
