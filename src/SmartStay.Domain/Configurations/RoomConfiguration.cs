using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Code)
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Floor)
                .IsRequired();
            builder.Property(r => r.Area)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(r => r.MaxOccupants)
                .HasDefaultValue(null);
            builder.Property(r => r.Description)
                .HasMaxLength(500);
            builder.Property(r => r.Status)
                .IsRequired()
                .HasDefaultValue(RoomStatus.Available);
            builder.Property(r => r.RoomType)
                .IsRequired();
            builder.HasOne(r => r.Building)
                .WithMany(b => b.Rooms)
                .HasForeignKey(r => r.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
