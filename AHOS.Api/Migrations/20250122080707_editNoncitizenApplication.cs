using System;
using System.Collections;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AHOS.Api.Migrations
{
    /// <inheritdoc />
    public partial class editNoncitizenApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitizenApplicationService_ServiceId",
                schema: "Patient",
                table: "CitizenApplicationService");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Gender",
                schema: "Patient",
                table: "CitizenPatient");

            migrationBuilder.DropColumn(
                name: "FatherName",
                schema: "Patient",
                table: "CitizenPatient");

            migrationBuilder.DropColumn(
                name: "MotherName",
                schema: "Patient",
                table: "CitizenPatient");

            migrationBuilder.DropColumn(
                name: "ApplicationTime",
                schema: "Patient",
                table: "CitizenApplication");

            migrationBuilder.RenameColumn(
                name: "ServiceReferanceId",
                schema: "Patient",
                table: "CitizenApplicationService",
                newName: "ServiceReferanceCode");

            migrationBuilder.AlterColumn<BitArray>(
                name: "PassportNumberVerified",
                schema: "Patient",
                table: "NonCitizenPatient",
                type: "bit(1)",
                nullable: false,
                oldClrType: typeof(BitArray),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                schema: "Patient",
                table: "NonCitizenPatient",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                schema: "Patient",
                table: "NonCitizenPatient",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "FamilyDoctorId",
                schema: "Patient",
                table: "CitizenApplicationService",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationStatus",
                schema: "Patient",
                table: "CitizenApplication",
                type: "integer",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.CreateTable(
                name: "NonCitizenApplication",
                schema: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationStatus = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("NonCitizenApplication_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonCitizenApplicationService",
                schema: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NonCitizenApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<BitArray>(type: "bit varying", nullable: false),
                    CreatedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTransactionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedTransactionId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedOn = table.Column<DateOnly>(type: "date", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedTransactionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    FamilyDoctorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    ServiceReferanceCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NonCitizenApplicationService_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonCitizenApplicationService_CitizenApplicationId",
                        column: x => x.NonCitizenApplicationId,
                        principalSchema: "Patient",
                        principalTable: "NonCitizenApplication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonCitizenApplicationService_FamilyDoctor_FamilyDoctorId",
                        column: x => x.FamilyDoctorId,
                        principalTable: "FamilyDoctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCitizenApplicationService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "Common",
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NonCitizenPatient_GenderId",
                schema: "Patient",
                table: "NonCitizenPatient",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenApplicationService_FamilyDoctorId",
                schema: "Patient",
                table: "CitizenApplicationService",
                column: "FamilyDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCitizenApplicationService_FamilyDoctorId",
                schema: "Patient",
                table: "NonCitizenApplicationService",
                column: "FamilyDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCitizenApplicationService_NonCitizenApplicationId",
                schema: "Patient",
                table: "NonCitizenApplicationService",
                column: "NonCitizenApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCitizenApplicationService_ServiceId",
                schema: "Patient",
                table: "NonCitizenApplicationService",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CitizenApplicationService_FamilyDoctor_FamilyDoctorId",
                schema: "Patient",
                table: "CitizenApplicationService",
                column: "FamilyDoctorId",
                principalTable: "FamilyDoctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CitizenApplicationService_Service_ServiceId",
                schema: "Patient",
                table: "CitizenApplicationService",
                column: "ServiceId",
                principalSchema: "Common",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CitizenPatient_Gender_GenderId",
                schema: "Patient",
                table: "CitizenPatient",
                column: "GenderId",
                principalSchema: "Common",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NonCitizenPatient_Gender_GenderId",
                schema: "Patient",
                table: "NonCitizenPatient",
                column: "GenderId",
                principalSchema: "Common",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitizenApplicationService_FamilyDoctor_FamilyDoctorId",
                schema: "Patient",
                table: "CitizenApplicationService");

            migrationBuilder.DropForeignKey(
                name: "FK_CitizenApplicationService_Service_ServiceId",
                schema: "Patient",
                table: "CitizenApplicationService");

            migrationBuilder.DropForeignKey(
                name: "FK_CitizenPatient_Gender_GenderId",
                schema: "Patient",
                table: "CitizenPatient");

            migrationBuilder.DropForeignKey(
                name: "FK_NonCitizenPatient_Gender_GenderId",
                schema: "Patient",
                table: "NonCitizenPatient");

            migrationBuilder.DropTable(
                name: "NonCitizenApplicationService",
                schema: "Patient");

            migrationBuilder.DropTable(
                name: "NonCitizenApplication",
                schema: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_NonCitizenPatient_GenderId",
                schema: "Patient",
                table: "NonCitizenPatient");

            migrationBuilder.DropIndex(
                name: "IX_CitizenApplicationService_FamilyDoctorId",
                schema: "Patient",
                table: "CitizenApplicationService");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                schema: "Patient",
                table: "NonCitizenPatient");

            migrationBuilder.DropColumn(
                name: "Nationality",
                schema: "Patient",
                table: "NonCitizenPatient");

            migrationBuilder.DropColumn(
                name: "FamilyDoctorId",
                schema: "Patient",
                table: "CitizenApplicationService");

            migrationBuilder.RenameColumn(
                name: "ServiceReferanceCode",
                schema: "Patient",
                table: "CitizenApplicationService",
                newName: "ServiceReferanceId");

            migrationBuilder.AlterColumn<BitArray>(
                name: "PassportNumberVerified",
                schema: "Patient",
                table: "NonCitizenPatient",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(BitArray),
                oldType: "bit(1)");

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                schema: "Patient",
                table: "CitizenPatient",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                schema: "Patient",
                table: "CitizenPatient",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<short>(
                name: "ApplicationStatus",
                schema: "Patient",
                table: "CitizenApplication",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ApplicationTime",
                schema: "Patient",
                table: "CitizenApplication",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddForeignKey(
                name: "FK_CitizenApplicationService_ServiceId",
                schema: "Patient",
                table: "CitizenApplicationService",
                column: "ServiceId",
                principalSchema: "Common",
                principalTable: "Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Gender",
                schema: "Patient",
                table: "CitizenPatient",
                column: "GenderId",
                principalSchema: "Common",
                principalTable: "Gender",
                principalColumn: "Id");
        }
    }
}
