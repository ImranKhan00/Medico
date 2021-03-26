using Microsoft.EntityFrameworkCore.Migrations;

namespace Medico.Migrations
{
    public partial class diagnosisAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiagnosisId",
                table: "Symptoms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Diagnoses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Diagnoses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiagnosisId",
                table: "Cures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Symptoms_DiagnosisId",
                table: "Symptoms",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cures_DiagnosisId",
                table: "Cures",
                column: "DiagnosisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cures_Diagnoses_DiagnosisId",
                table: "Cures",
                column: "DiagnosisId",
                principalTable: "Diagnoses",
                principalColumn: "DiagnosisId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Symptoms_Diagnoses_DiagnosisId",
                table: "Symptoms",
                column: "DiagnosisId",
                principalTable: "Diagnoses",
                principalColumn: "DiagnosisId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cures_Diagnoses_DiagnosisId",
                table: "Cures");

            migrationBuilder.DropForeignKey(
                name: "FK_Symptoms_Diagnoses_DiagnosisId",
                table: "Symptoms");

            migrationBuilder.DropIndex(
                name: "IX_Symptoms_DiagnosisId",
                table: "Symptoms");

            migrationBuilder.DropIndex(
                name: "IX_Cures_DiagnosisId",
                table: "Cures");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "Symptoms");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "Cures");
        }
    }
}
