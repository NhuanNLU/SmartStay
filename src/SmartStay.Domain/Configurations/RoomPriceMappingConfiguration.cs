using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;

namespace SmartStay.Domain.Configurations
{
    public class RoomPriceMappingConfiguration :
        IEntityTypeConfiguration<RoomPriceMapping>
    {
        public void Configure(EntityTypeBuilder<RoomPriceMapping> builder)
        {
            builder.HasKey(rpm => new { rpm.RoomId, rpm.RoomPriceId });
            builder.HasOne(rpm => rpm.Room)
                .WithMany(r => r.RoomPriceMappings)
                .HasForeignKey(rpm => rpm.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(rpm => rpm.RoomPrice)
                .WithMany(rp => rp.RoomPriceMappings)
                .HasForeignKey(rpm => rpm.RoomPriceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
