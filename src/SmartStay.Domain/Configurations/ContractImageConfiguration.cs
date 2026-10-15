using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;

namespace SmartStay.Domain.Configurations
{
    public class ContractImageConfiguration : IEntityTypeConfiguration<ContractImage>
    {
        public void Configure(EntityTypeBuilder<ContractImage> builder)
        {
            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.ImageUrl)
                .IsRequired()
                .HasMaxLength(255);
            builder.HasOne(ci => ci.Contract)
                .WithMany(c => c.ContractImages)
                .HasForeignKey(ci => ci.ContractId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
