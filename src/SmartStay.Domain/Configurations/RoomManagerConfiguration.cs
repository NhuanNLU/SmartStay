using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class RoomManagerConfiguration : IEntityTypeConfiguration<RoomManager>
    {
        public void Configure(EntityTypeBuilder<RoomManager> builder)
        {
            builder.HasKey(rm => new {rm.UserId, rm.RoomId});
            builder.Property( rm => rm.Status)
                .IsRequired()
                .HasDefaultValue(RoomManagerStatus.Active);
            builder.HasOne(rm => rm.User)
                .WithMany(u => u.RoomManagers)
                .HasForeignKey(rm => rm.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(rm => rm.Room)
                .WithMany(r => r.RoomManagers)
                .HasForeignKey(rm => rm.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
