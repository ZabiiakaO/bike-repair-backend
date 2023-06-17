using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeRepairAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BikeRepairRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BikeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BikeBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePackage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceUnits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostCeiling = table.Column<string>(type: "nvarchar(max)", nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeRepairRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
              name: "BikeTypeRequests",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_BikeTypeRequests", x => x.Id);
              });

            migrationBuilder.CreateTable(
             name: "BrandRequests",
             columns: table => new
             {
                 Id = table.Column<int>(type: "int", nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_BrandRequests", x => x.Id);
             });

            migrationBuilder.CreateTable(
             name: "ServicePackageRequets",
             columns: table => new
             {
                 Id = table.Column<int>(type: "int", nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                 Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                 Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                 IsElectroBike = table.Column<bool>(type: "bit", nullable: true),
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_ServicePackagesRequets", x => x.Id);
             });

            migrationBuilder.CreateTable(
             name: "ServiceUnitsRequets",
             columns: table => new
             {
                 Id = table.Column<int>(type: "int", nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 Value = table.Column<bool>(type: "bit ", nullable: true),
                 IsElectroBike = table.Column<bool>(type: "bit", nullable: true)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_ServiceUnitsRequets", x => x.Id);
             });

        }



        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BikeRepairRequests");
            migrationBuilder.DropTable(
               name: "BikeTypeRequests");
            migrationBuilder.DropTable(
              name: "BrandRequests");
            migrationBuilder.DropTable(
             name: "ServicePackagesRequets");
            migrationBuilder.DropTable(
             name: "ServiceUnitsRequets");
        }
    }
}
