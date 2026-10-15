using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class BuildingConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Address)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(b => b.Name)
                .HasMaxLength(100);
            builder.Property(b => b.Description)
                .HasMaxLength(500);
            builder.Property(b => b.BuildingType)
                .IsRequired();
            builder.Property(b => b.FloorCount)
                .IsRequired();
            builder.Property(b => b.Status)
                .IsRequired()
                .HasDefaultValue(BuildingStatus.Inactive);
            builder.HasOne(b => b.Branch)
                .WithMany(br => br.Buildings)
                .HasForeignKey(b => b.BranchId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
