using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    HospitalAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    OccupationId = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    HospitalId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StaffRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalStaff_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalStaff_StaffRole_StaffRoleId",
                        column: x => x.StaffRoleId,
                        principalTable: "StaffRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    AddressTypeId = table.Column<int>(nullable: false),
                    HouseNo = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressTypes_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    DiseaseId = table.Column<int>(nullable: false),
                    DiseaseTypeId = table.Column<int>(nullable: false),
                    TreatmenStatusId = table.Column<int>(nullable: false),
                    AdmittedOn = table.Column<DateTime>(nullable: false),
                    RelievingOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatment_DiseaseDetails_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "DiseaseDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatment_DiseaseType_DiseaseTypeId",
                        column: x => x.DiseaseTypeId,
                        principalTable: "DiseaseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatment_HospitalStaff_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "HospitalStaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatment_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatment_TreatmentStatus_TreatmenStatusId",
                        column: x => x.TreatmenStatusId,
                        principalTable: "TreatmentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    TreatmenId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_Treatment_TreatmenId",
                        column: x => x.TreatmenId,
                        principalTable: "Treatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PatientId",
                table: "Address",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalStaff_HospitalId",
                table: "HospitalStaff",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalStaff_StaffRoleId",
                table: "HospitalStaff",
                column: "StaffRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_OccupationId",
                table: "Patient",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_TreatmenId",
                table: "Prescription",
                column: "TreatmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_DiseaseId",
                table: "Treatment",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_DiseaseTypeId",
                table: "Treatment",
                column: "DiseaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_DoctorId",
                table: "Treatment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_PatientId",
                table: "Treatment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_TreatmenStatusId",
                table: "Treatment",
                column: "TreatmenStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Treatment");

            migrationBuilder.DropTable(
                name: "DiseaseDetails");

            migrationBuilder.DropTable(
                name: "DiseaseType");

            migrationBuilder.DropTable(
                name: "HospitalStaff");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "TreatmentStatus");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "StaffRole");

            migrationBuilder.DropTable(
                name: "Occupations");
        }
    }
}
