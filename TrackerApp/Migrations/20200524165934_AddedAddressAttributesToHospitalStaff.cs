using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class AddedAddressAttributesToHospitalStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Patient",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Pincode",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "HospitalStaff",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "City",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "State",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "HospitalStaff");
        }
    }
}
