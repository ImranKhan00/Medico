using Microsoft.EntityFrameworkCore.Migrations;

namespace Medico.Migrations
{
    public partial class misspellCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymtomsId",
                table: "DiseaseSymptoms");

            migrationBuilder.RenameColumn(
                name: "SymtomsId",
                table: "Symptoms",
                newName: "SymptomId");

            migrationBuilder.RenameColumn(
                name: "SymptomsSymtomsId",
                table: "DiseaseSymptoms",
                newName: "SymptomsSymptomId");

            migrationBuilder.RenameIndex(
                name: "IX_DiseaseSymptoms_SymptomsSymtomsId",
                table: "DiseaseSymptoms",
                newName: "IX_DiseaseSymptoms_SymptomsSymptomId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymptomId",
                table: "DiseaseSymptoms",
                column: "SymptomsSymptomId",
                principalTable: "Symptoms",
                principalColumn: "SymptomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymptomId",
                table: "DiseaseSymptoms");

            migrationBuilder.RenameColumn(
                name: "SymptomId",
                table: "Symptoms",
                newName: "SymtomsId");

            migrationBuilder.RenameColumn(
                name: "SymptomsSymptomId",
                table: "DiseaseSymptoms",
                newName: "SymptomsSymtomsId");

            migrationBuilder.RenameIndex(
                name: "IX_DiseaseSymptoms_SymptomsSymptomId",
                table: "DiseaseSymptoms",
                newName: "IX_DiseaseSymptoms_SymptomsSymtomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymtomsId",
                table: "DiseaseSymptoms",
                column: "SymptomsSymtomsId",
                principalTable: "Symptoms",
                principalColumn: "SymtomsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
