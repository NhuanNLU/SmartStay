using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartStay.Domain.Entities;

namespace SmartStay.Domain.Configurations
{
    public class BranchManagerConfiguration : IEntityTypeConfiguration<BranchManager>
    {
        public void Configure(EntityTypeBuilder<BranchManager> builder)
        {
            builder.HasOne(bm => bm.User)
                .WithMany(u => u.BranchManagers)
                .HasForeignKey(bm => bm.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(bm => bm.Branch)
                .WithMany(b => b.BranchManagers)
                .HasForeignKey(bm => bm.BranchId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasKey(bm => new { bm.UserId, bm.BranchId });
        }
    }
}
