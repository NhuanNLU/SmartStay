using Microsoft.EntityFrameworkCore;
using SmartStay.Domain.Configurations;
using SmartStay.Domain.Entities;
namespace SmartStay.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchManager> BranchManagers { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Domain.Entities.Contract> Contracts { get; set; }
        public DbSet<ContractImage> ContractImages { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenity> RoomAmenities { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<RoomManager> RoomManagers { get; set; }
        public DbSet<RoomPrice> RoomPrices { get; set; }
        public DbSet<RoomPriceFee> RoomPriceFees { get; set; }
        public DbSet<RoomPriceFeeMapping> RoomPriceFeeMappings { get; set; }
        public DbSet<RoomPriceMapping> RoomPriceMappings { get; set; }
        public DbSet<RoomViewing> RoomViewings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UtilityReading> UtilityReadings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}
