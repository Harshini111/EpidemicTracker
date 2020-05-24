using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class AddPhoneChangePhoneType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Phone",
                table: "Patient",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "Phone",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "HospitalStaff");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Patient",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
