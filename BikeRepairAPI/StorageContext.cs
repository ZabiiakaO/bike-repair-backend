using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BikeRepairAPI
{
    public class StorageContext: DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options) : base(options) { }

        public DbSet<BikeRepairRequest> BikeRepairRequests => Set<BikeRepairRequest>();

        public DbSet<BikeTypeRequest> BikeTypeRequests => Set<BikeTypeRequest>();

        public DbSet<BrandRequest> BrandRequests => Set<BrandRequest>();

        public DbSet<ServicePackageRequest> ServicePackageRequests => Set<ServicePackageRequest>();

        public DbSet<ServiceUnitRequest> ServiceUnitRequests => Set<ServiceUnitRequest>();
    }
}
