namespace CoffeCodeDevops.Data.Models
{
    public class FeedbackModel
    {
        public Guid FeedbackId { get; set; }
        public int PresentationNote { get; set; }
        public int SpeakerNote { get; set; }
        public int NextWorkshop { get; set; }
        public string? Feedback { get; set; }

    }
}
