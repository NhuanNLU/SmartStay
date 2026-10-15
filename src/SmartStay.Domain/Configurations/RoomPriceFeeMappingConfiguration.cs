using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;

namespace SmartStay.Domain.Configurations
{
    public class RoomPriceFeeMappingConfiguration : IEntityTypeConfiguration<RoomPriceFeeMapping>
    {
        public void Configure(EntityTypeBuilder<RoomPriceFeeMapping> builder)
        {
            builder.HasKey(rpfm => new { rpfm.RoomId, rpfm.RoomPriceFeeId });
            builder.HasOne(rpfm => rpfm.Room)
                .WithMany(r => r.RoomPriceFeeMappings)
                .HasForeignKey(rpfm => rpfm.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(rpfm => rpfm.RoomPriceFee)
                .WithMany(rpf => rpf.RoomPriceFeeMappings)
                .HasForeignKey(rpfm => rpfm.RoomPriceFeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
