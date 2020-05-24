using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class AddedHospitaAddressInHospital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalAddress",
                table: "Hospital");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Hospital",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hospital",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Hospital",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Pincode",
                table: "Hospital",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Hospital",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Hospital");

            migrationBuilder.AddColumn<string>(
                name: "HospitalAddress",
                table: "Hospital",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
