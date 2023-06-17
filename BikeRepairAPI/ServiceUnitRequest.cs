 

namespace BikeRepairAPI
{
    public class ServiceUnitRequest
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public bool Value { get; set; } = false;

        public bool IsElectroBike { get; set; } = false;
    }
}
