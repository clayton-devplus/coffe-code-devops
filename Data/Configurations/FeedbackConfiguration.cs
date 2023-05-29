using CoffeCodeDevops.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeCodeDevops.Data.Configurations
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<FeedbackModel>
    {
        public void Configure(EntityTypeBuilder<FeedbackModel> builder)
        {
            builder.ToTable("feedbacks");

            builder.HasKey(x => new { x.FeedbackId });
        }
    }
}
