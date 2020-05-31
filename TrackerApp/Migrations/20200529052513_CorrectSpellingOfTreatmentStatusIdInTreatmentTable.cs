using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class CorrectSpellingOfTreatmentStatusIdInTreatmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_TreatmentStatus_TreatmenStatusId",
                table: "Treatment");

            migrationBuilder.DropIndex(
                name: "IX_Treatment_TreatmenStatusId",
                table: "Treatment");

            migrationBuilder.DropColumn(
                name: "TreatmenStatusId",
                table: "Treatment");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentStatusId",
                table: "Treatment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_TreatmentStatusId",
                table: "Treatment",
                column: "TreatmentStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_TreatmentStatus_TreatmentStatusId",
                table: "Treatment",
                column: "TreatmentStatusId",
                principalTable: "TreatmentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatment_TreatmentStatus_TreatmentStatusId",
                table: "Treatment");

            migrationBuilder.DropIndex(
                name: "IX_Treatment_TreatmentStatusId",
                table: "Treatment");

            migrationBuilder.DropColumn(
                name: "TreatmentStatusId",
                table: "Treatment");

            migrationBuilder.AddColumn<int>(
                name: "TreatmenStatusId",
                table: "Treatment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_TreatmenStatusId",
                table: "Treatment",
                column: "TreatmenStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatment_TreatmentStatus_TreatmenStatusId",
                table: "Treatment",
                column: "TreatmenStatusId",
                principalTable: "TreatmentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
