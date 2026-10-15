using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class RoomViewingConfiguration : IEntityTypeConfiguration<RoomViewing>
    {
        public void Configure(EntityTypeBuilder<RoomViewing> builder)
        {
            builder.HasKey(rv => rv.Id);
            builder.HasOne(rv => rv.User)
                .WithMany(u => u.RoomViewings)
                .HasForeignKey(rv => rv.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(rv => rv.Room)
                .WithMany(r => r.RoomViewings)
                .HasForeignKey(rv => rv.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(rv => rv.ScheduledAt)
                .IsRequired();
            builder.Property(rv => rv.CustomerNote)
                .HasMaxLength(1000);
            builder.Property(rv => rv.AttendeeCount)
                .IsRequired();
            builder.Property(rv => rv.Status)
                .IsRequired()
                .HasDefaultValue(RoomViewingStatus.Pending);
            builder.Property(rv => rv.Result)
                .IsRequired()
                .HasDefaultValue(RoomViewingResult.None);
        }
    }
}
