using Microsoft.EntityFrameworkCore;

namespace BikeRepairAPI
{
    public class StorageContext: DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options) : base(options) { }

        public DbSet<BikeRepairRequest> BikeRepairRequests => Set<BikeRepairRequest>();
    }
}
