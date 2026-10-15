using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ContractCode)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasIndex(c => c.ContractCode)
                .IsUnique();
            builder.Property(c => c.StartDate)
                .IsRequired();
            builder.Property(c => c.EndDate)
                .IsRequired();
            builder.Property(c => c.Status)
                .IsRequired()
                .HasDefaultValue(ContractStatus.Draft);
            builder.HasOne(c => c.Room)
                .WithMany(r => r.Contracts)
                .HasForeignKey(c => c.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.User)
                .WithMany(u => u.Contracts)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
