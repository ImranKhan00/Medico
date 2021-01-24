using Microsoft.EntityFrameworkCore.Migrations;

namespace Medico.Migrations
{
    public partial class relationshipsDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CureDisease",
                columns: table => new
                {
                    CuresCureId = table.Column<int>(type: "int", nullable: false),
                    DiseasesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CureDisease", x => new { x.CuresCureId, x.DiseasesId });
                    table.ForeignKey(
                        name: "FK_CureDisease_Cures_CuresCureId",
                        column: x => x.CuresCureId,
                        principalTable: "Cures",
                        principalColumn: "CureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CureDisease_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisDisease",
                columns: table => new
                {
                    DiagnosesDiagnosisId = table.Column<int>(type: "int", nullable: false),
                    DiseasesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisDisease", x => new { x.DiagnosesDiagnosisId, x.DiseasesId });
                    table.ForeignKey(
                        name: "FK_DiagnosisDisease_Diagnoses_DiagnosesDiagnosisId",
                        column: x => x.DiagnosesDiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "DiagnosisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisDisease_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseasePrecaution",
                columns: table => new
                {
                    DiseasesId = table.Column<int>(type: "int", nullable: false),
                    PrecautionsPrecautionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasePrecaution", x => new { x.DiseasesId, x.PrecautionsPrecautionId });
                    table.ForeignKey(
                        name: "FK_DiseasePrecaution_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasePrecaution_Precautions_PrecautionsPrecautionId",
                        column: x => x.PrecautionsPrecautionId,
                        principalTable: "Precautions",
                        principalColumn: "PrecautionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseSymptoms",
                columns: table => new
                {
                    DiseasesId = table.Column<int>(type: "int", nullable: false),
                    SymptomsSymtomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptoms", x => new { x.DiseasesId, x.SymptomsSymtomsId });
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymtomsId",
                        column: x => x.SymptomsSymtomsId,
                        principalTable: "Symptoms",
                        principalColumn: "SymtomsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CureDisease_DiseasesId",
                table: "CureDisease",
                column: "DiseasesId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisDisease_DiseasesId",
                table: "DiagnosisDisease",
                column: "DiseasesId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasePrecaution_PrecautionsPrecautionId",
                table: "DiseasePrecaution",
                column: "PrecautionsPrecautionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptoms_SymptomsSymtomsId",
                table: "DiseaseSymptoms",
                column: "SymptomsSymtomsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CureDisease");

            migrationBuilder.DropTable(
                name: "DiagnosisDisease");

            migrationBuilder.DropTable(
                name: "DiseasePrecaution");

            migrationBuilder.DropTable(
                name: "DiseaseSymptoms");
        }
    }
}
