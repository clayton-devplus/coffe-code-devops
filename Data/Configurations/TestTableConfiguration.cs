using CoffeCodeDevops.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeCodeDevops.Data.Configurations
{
    public class TestTableConfiguration : IEntityTypeConfiguration<TestTableModel>
    {
        public void Configure(EntityTypeBuilder<TestTableModel> builder)
        {
            builder.ToTable("test_table_devops");

            builder.HasKey(x => new { x.tableId });


            builder.Property(x => x.tableId)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("table_id");

            builder.Property(x => x.tableName)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("table_name");


            builder.Property(x => x.tableType)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("table_type");

        }
    }
}
