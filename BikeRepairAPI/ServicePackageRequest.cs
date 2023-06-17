 
namespace BikeRepairAPI
{
    public class ServicePackageRequest
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public bool IsElectroBike { get; set; } = false;
    }
}
