using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;

namespace SmartStay.Domain.Configurations
{
    public class UtilityReadingConfiguration : 
        IEntityTypeConfiguration<UtilityReading>
    {
        public void Configure(EntityTypeBuilder<UtilityReading> builder)
        {
            builder.HasKey(ur => ur.Id);
            builder.Property(ur => ur.OldElectric).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(ur => ur.NewElectric).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(ur => ur.OldWater).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(ur => ur.NewWater).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(ur => ur.ElectricUnitPrice).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(ur => ur.WaterUnitPrice).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(ur => ur.RecordingDate).IsRequired();
            builder.HasOne(ur => ur.Room)
                .WithMany(r => r.UtilityReadings)
                .HasForeignKey(ur => ur.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
