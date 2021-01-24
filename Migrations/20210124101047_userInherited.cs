using Microsoft.EntityFrameworkCore.Migrations;

namespace Medico.Migrations
{
    public partial class userInherited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_User_UserId",
                table: "Diagnosis");

            migrationBuilder.DropTable(
                name: "DiagnoseDisease");

            migrationBuilder.DropTable(
                name: "DiseaseCure");

            migrationBuilder.DropTable(
                name: "DiseasePrecaution");

            migrationBuilder.DropTable(
                name: "DiseaseSymptoms");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Precaution",
                table: "Precaution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disease",
                table: "Disease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cure",
                table: "Cure");

            migrationBuilder.RenameTable(
                name: "Precaution",
                newName: "Precautions");

            migrationBuilder.RenameTable(
                name: "Disease",
                newName: "Diseases");

            migrationBuilder.RenameTable(
                name: "Diagnosis",
                newName: "Diagnoses");

            migrationBuilder.RenameTable(
                name: "Cure",
                newName: "Cures");

            migrationBuilder.RenameColumn(
                name: "DiseaseId",
                table: "Diseases",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnosis_UserId",
                table: "Diagnoses",
                newName: "IX_Diagnoses_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Symptoms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Precautions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Diagnoses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Precautions",
                table: "Precautions",
                column: "PrecautionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diseases",
                table: "Diseases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnoses",
                table: "Diagnoses",
                column: "DiagnosisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cures",
                table: "Cures",
                column: "CureId");

            migrationBuilder.CreateTable(
                name: "DiagnosedDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DiseaseId = table.Column<int>(type: "int", nullable: true),
                    DiagnosisId = table.Column<int>(type: "int", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosedDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosedDiseases_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiagnosedDiseases_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "DiagnosisId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiagnosedDiseases_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosedDiseases_DiagnosisId",
                table: "DiagnosedDiseases",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosedDiseases_DiseaseId",
                table: "DiagnosedDiseases",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosedDiseases_UserId",
                table: "DiagnosedDiseases",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_AspNetUsers_UserId",
                table: "Diagnoses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_AspNetUsers_UserId",
                table: "Diagnoses");

            migrationBuilder.DropTable(
                name: "DiagnosedDiseases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Precautions",
                table: "Precautions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diseases",
                table: "Diseases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnoses",
                table: "Diagnoses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cures",
                table: "Cures");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Symptoms");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Precautions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cures");

            migrationBuilder.RenameTable(
                name: "Precautions",
                newName: "Precaution");

            migrationBuilder.RenameTable(
                name: "Diseases",
                newName: "Disease");

            migrationBuilder.RenameTable(
                name: "Diagnoses",
                newName: "Diagnosis");

            migrationBuilder.RenameTable(
                name: "Cures",
                newName: "Cure");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Disease",
                newName: "DiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnoses_UserId",
                table: "Diagnosis",
                newName: "IX_Diagnosis_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Diagnosis",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Precaution",
                table: "Precaution",
                column: "PrecautionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disease",
                table: "Disease",
                column: "DiseaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis",
                column: "DiagnosisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cure",
                table: "Cure",
                column: "CureId");

            migrationBuilder.CreateTable(
                name: "DiseaseCure",
                columns: table => new
                {
                    DiseaseCureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CureId = table.Column<int>(type: "int", nullable: true),
                    DiseaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseCure", x => x.DiseaseCureId);
                    table.ForeignKey(
                        name: "FK_DiseaseCure_Cure_CureId",
                        column: x => x.CureId,
                        principalTable: "Cure",
                        principalColumn: "CureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseaseCure_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiseasePrecaution",
                columns: table => new
                {
                    DiseasePrecautionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(type: "int", nullable: true),
                    PrecautionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasePrecaution", x => x.DiseasePrecautionId);
                    table.ForeignKey(
                        name: "FK_DiseasePrecaution_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseasePrecaution_Precaution_PrecautionId",
                        column: x => x.PrecautionId,
                        principalTable: "Precaution",
                        principalColumn: "PrecautionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseSymptoms",
                columns: table => new
                {
                    DiseaseSymptomsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(type: "int", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymptomsSymtomsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptoms", x => x.DiseaseSymptomsId);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymtomsId",
                        column: x => x.SymptomsSymtomsId,
                        principalTable: "Symptoms",
                        principalColumn: "SymtomsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DiagnoseDisease",
                columns: table => new
                {
                    DiagnoseDiseaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: true),
                    DiseaseId = table.Column<int>(type: "int", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnoseDisease", x => x.DiagnoseDiseaseId);
                    table.ForeignKey(
                        name: "FK_DiagnoseDisease_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "DiagnosisId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiagnoseDisease_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiagnoseDisease_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnoseDisease_DiagnosisId",
                table: "DiagnoseDisease",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnoseDisease_DiseaseId",
                table: "DiagnoseDisease",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnoseDisease_UserId",
                table: "DiagnoseDisease",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseCure_CureId",
                table: "DiseaseCure",
                column: "CureId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseCure_DiseaseId",
                table: "DiseaseCure",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasePrecaution_DiseaseId",
                table: "DiseasePrecaution",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasePrecaution_PrecautionId",
                table: "DiseasePrecaution",
                column: "PrecautionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptoms_DiseaseId",
                table: "DiseaseSymptoms",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptoms_SymptomsSymtomsId",
                table: "DiseaseSymptoms",
                column: "SymptomsSymtomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_User_UserId",
                table: "Diagnosis",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
