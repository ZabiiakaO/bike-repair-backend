using Microsoft.AspNetCore.Components.Forms;
using System.Collections;

namespace BikeRepairAPI
{
    public class BikeRepairRequest
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string No { get; set; } = string.Empty;
        public string Postcode { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string BikeType { get; set; } = string.Empty;
        public string BikeBrand { get; set; } = string.Empty;
        public string ServicePackage { get; set; } = string.Empty;
        public string ServiceUnits { get; set; } = string.Empty;
        public string CostCeiling { get; set; } = string.Empty; 
    }
} 
 