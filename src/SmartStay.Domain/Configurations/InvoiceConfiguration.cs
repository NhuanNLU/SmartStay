using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(i => i.InvoiceCode)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasIndex(i => i.InvoiceCode)
                .IsUnique();
            builder.Property(i => i.Status)
                .IsRequired()
                .HasDefaultValue(InvoiceStatus.Draft);
            builder.Property(i => i.Note)
                .HasMaxLength(500);
            builder.HasOne(i => i.User)
                .WithMany(u => u.Invoices)
                .HasForeignKey(i => i.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(i => i.Room)
                .WithMany(r => r.Invoices)
                .HasForeignKey(i => i.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
