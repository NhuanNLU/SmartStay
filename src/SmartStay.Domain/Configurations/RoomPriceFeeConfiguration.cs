using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;

namespace SmartStay.Domain.Configurations

{
    public class RoomPriceFeeConfiguration : IEntityTypeConfiguration<RoomPriceFee>
    {
        public void Configure(EntityTypeBuilder<RoomPriceFee> builder)
        {
            builder.HasKey(rpf => rpf.Id);
            builder.Property(rpf => rpf.FeeName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(rpf => rpf.Amount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
        }
    }
}
