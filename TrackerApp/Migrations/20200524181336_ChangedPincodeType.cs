using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class ChangedPincodeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Pincode",
                table: "HospitalStaff",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pincode",
                table: "Hospital",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "HospitalStaff");

            migrationBuilder.AlterColumn<long>(
                name: "Pincode",
                table: "HospitalStaff",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Pincode",
                table: "Hospital",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
