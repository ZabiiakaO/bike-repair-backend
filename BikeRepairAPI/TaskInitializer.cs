using Microsoft.EntityFrameworkCore;

namespace BikeRepairAPI
{
    public static class TaskInitializer
    {
        public static WebApplication Seed(this WebApplication app) 
        {
            using var scope = app.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<StorageContext>();
            try
            {
                context.Database.EnsureCreated();
                var taskTypes = context.BikeTypeRequests.FirstOrDefault();
                if (taskTypes == null)
                {
                    context.BikeTypeRequests.AddRange(
                        new BikeTypeRequest { Name = "Road bike" },
                        new BikeTypeRequest { Name = "Trekking bike" },
                        new BikeTypeRequest { Name = "Ebike" }
                        );
                     
                }
                var taskBrand = context.BrandRequests.FirstOrDefault();
                if (taskBrand == null)
                {
                    context.BrandRequests.AddRange(
                        new BrandRequest { Name = "Trek" },
                        new BrandRequest { Name = "BMC" },
                        new BrandRequest { Name = "Scott" }
                        );

                    
                }

                var taskPackages = context.ServicePackageRequests.FirstOrDefault();
                if (taskPackages == null)
                {
                    context.ServicePackageRequests.AddRange(
                        new ServicePackageRequest { Name = "Check Up", Description= "Check-Up, ca", Price="50", Currency= "CHF" },
                        new ServicePackageRequest { Name = "Service small", Description = "Service small, about", Price = "120", Currency = "CHF" },
                        new ServicePackageRequest { Name = "Service large", Description = "Service large, approx", Price = "170", Currency = "CHF" }
                        ); 
                }

                var taskUnits = context.ServiceUnitRequests.FirstOrDefault();
                if (taskUnits == null)
                {
                    context.ServiceUnitRequests.AddRange(
                        new ServiceUnitRequest { Name = "Tube and/or tire change", IsElectroBike = false},
                       new ServiceUnitRequest { Name = "Center Wheels", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Set circuit", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Check and adjust brakes", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Change brake pads", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Fork Service", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Damper Service", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Bike complete cleaning", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Control light", IsElectroBike = false },
                        new ServiceUnitRequest { Name = "Function check electronics/drive", IsElectroBike = true },
                        new ServiceUnitRequest { Name = "Check and charge battery", IsElectroBike = true }
                        );
                }
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return app;
        }

        
    }
}
