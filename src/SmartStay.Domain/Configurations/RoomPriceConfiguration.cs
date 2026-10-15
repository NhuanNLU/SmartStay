using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Configurations
{
    public class RoomPriceConfiguration : IEntityTypeConfiguration<RoomPrice>
    {
        public void Configure(EntityTypeBuilder<RoomPrice> builder)
        {
            builder.HasKey(rp => rp.Id);
            builder.Property(rp => rp.EffectiveFrom).IsRequired();
            builder.Property(rp => rp.RentAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(rp => rp.Status)
                .IsRequired()
                .HasDefaultValue(RoomPriceStatus.Draft);
            
        }
    }
}
