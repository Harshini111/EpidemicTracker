using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class CorrectSpellingOfTreatmentIdInTreatmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Treatment_TreatmenId",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_TreatmenId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "TreatmenId",
                table: "Prescription");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentId",
                table: "Prescription",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_TreatmentId",
                table: "Prescription",
                column: "TreatmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Treatment_TreatmentId",
                table: "Prescription",
                column: "TreatmentId",
                principalTable: "Treatment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Treatment_TreatmentId",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_TreatmentId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "TreatmentId",
                table: "Prescription");

            migrationBuilder.AddColumn<int>(
                name: "TreatmenId",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_TreatmenId",
                table: "Prescription",
                column: "TreatmenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Treatment_TreatmenId",
                table: "Prescription",
                column: "TreatmenId",
                principalTable: "Treatment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
