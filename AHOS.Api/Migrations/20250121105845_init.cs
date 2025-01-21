using System;
using System.Collections;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AHOS.Api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Patient");

            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.CreateTable(
                name: "CitizenApplication",
                schema: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationTime = table.Column<DateOnly>(type: "date", nullable: false),
                    ApplicationStatus = table.Column<short>(type: "smallint", nullable: false),
                    IsDeleted = table.Column<BitArray>(type: "bit varying", nullable: false),
                    CreatedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedTransactionId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedTransactionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CitizenApplication_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("City_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDoctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    SurName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FamilyDoctor_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    CodeStr = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Gender_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    CodeStr = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Nationality_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoncitizenPatientType",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    CodeStr = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NoncitizenPatientType_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Service_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitizenPatient",
                schema: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdentityNumber = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<BitArray>(type: "bit(1)", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    GenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BirthPlace = table.Column<string>(type: "text", nullable: false),
                    Deceased = table.Column<BitArray>(type: "bit(1)", nullable: false),
                    MotherName = table.Column<string>(type: "text", nullable: false),
                    FatherName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<BitArray>(type: "bit varying", nullable: false),
                    CreatedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedTransactionId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedTransactionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CitizenPatient_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Gender",
                        column: x => x.GenderId,
                        principalSchema: "Common",
                        principalTable: "Gender",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NonCitizenPatient",
                schema: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Active = table.Column<BitArray>(type: "bit(1)", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    GenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Deceased = table.Column<BitArray>(type: "bit(1)", nullable: false),
                    PassportNumber = table.Column<string>(type: "text", nullable: false),
                    PassportNumberVerified = table.Column<BitArray>(type: "bit(1)", nullable: true),
                    NoncitizenPatientTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    NationalityId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<BitArray>(type: "bit varying", nullable: false),
                    CreatedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedTransactionId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedTransactionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NonCitizenPatient_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_NoncitizenPatientType",
                        column: x => x.NoncitizenPatientTypeId,
                        principalSchema: "Common",
                        principalTable: "NoncitizenPatientType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CitizenApplicationService",
                schema: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CitizenApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    ServiceReferanceId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<BitArray>(type: "bit varying", nullable: false),
                    CreatedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedTransactionId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedTransactionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CitizenApplicationService_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitizenApplicationService_CitizenApplicationId",
                        column: x => x.CitizenApplicationId,
                        principalSchema: "Patient",
                        principalTable: "CitizenApplication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CitizenApplicationService_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "Common",
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitizenApplicationService_CitizenApplicationId",
                schema: "Patient",
                table: "CitizenApplicationService",
                column: "CitizenApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenApplicationService_ServiceId",
                schema: "Patient",
                table: "CitizenApplicationService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenPatient_GenderId",
                schema: "Patient",
                table: "CitizenPatient",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCitizenPatient_NoncitizenPatientTypeId",
                schema: "Patient",
                table: "NonCitizenPatient",
                column: "NoncitizenPatientTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenApplicationService",
                schema: "Patient");

            migrationBuilder.DropTable(
                name: "CitizenPatient",
                schema: "Patient");

            migrationBuilder.DropTable(
                name: "City",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "FamilyDoctor");

            migrationBuilder.DropTable(
                name: "Nationality",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "NonCitizenPatient",
                schema: "Patient");

            migrationBuilder.DropTable(
                name: "CitizenApplication",
                schema: "Patient");

            migrationBuilder.DropTable(
                name: "Service",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "NoncitizenPatientType",
                schema: "Common");
        }
    }
}
