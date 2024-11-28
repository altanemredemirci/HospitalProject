using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilces_Ils_IlId",
                        column: x => x.IlId,
                        principalTable: "Ils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hastahanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastahanes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hastahanes_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hastas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kangrubu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    TakipliMi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hastas_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kliniks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastahaneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kliniks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kliniks_Hastahanes_HastahaneId",
                        column: x => x.HastahaneId,
                        principalTable: "Hastahanes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doktors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KlinikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktors_Kliniks_KlinikID",
                        column: x => x.KlinikID,
                        principalTable: "Kliniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    KlinikId = table.Column<int>(type: "int", nullable: false),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    HastaId = table.Column<int>(type: "int", nullable: false),
                    _RandevuTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _RandevuSaati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastahaneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevus_Doktors_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevus_Hastahanes_HastahaneId",
                        column: x => x.HastahaneId,
                        principalTable: "Hastahanes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Randevus_Hastas_HastaId",
                        column: x => x.HastaId,
                        principalTable: "Hastas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevus_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevus_Kliniks_KlinikId",
                        column: x => x.KlinikId,
                        principalTable: "Kliniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doktors_KlinikID",
                table: "Doktors",
                column: "KlinikID");

            migrationBuilder.CreateIndex(
                name: "IX_Hastahanes_IlceId",
                table: "Hastahanes",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Hastas_IlceId",
                table: "Hastas",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_IlId",
                table: "Ilces",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Kliniks_HastahaneId",
                table: "Kliniks",
                column: "HastahaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastahaneId",
                table: "Randevus",
                column: "HastahaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaId",
                table: "Randevus",
                column: "HastaId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_IlceId",
                table: "Randevus",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_KlinikId",
                table: "Randevus",
                column: "KlinikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Doktors");

            migrationBuilder.DropTable(
                name: "Hastas");

            migrationBuilder.DropTable(
                name: "Kliniks");

            migrationBuilder.DropTable(
                name: "Hastahanes");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "Ils");
        }
    }
}
