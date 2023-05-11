using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.DataAccess.Migrations
{
    public partial class _1001_FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: false),
                    KullaniciSifre = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    KullaniciYetki = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departmans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaSeriNo = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    FaturaSıraNo = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VergiDairesi = table.Column<string>(type: "Varchar(60)", maxLength: 60, nullable: false),
                    saat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimEden = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    TeslimAlan = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "giderSiniflaris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giderSiniflaris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "katagoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KatagoriAdi = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_katagoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "satisHareketleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_satisHareketleris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faturaKalems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faturaKalems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_faturaKalems_faturas_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "faturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariAd = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    CariSoyad = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    CariSehir = table.Column<string>(type: "Varchar(16)", maxLength: 16, nullable: false),
                    CariMail = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    satisHareketleriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_caris_satisHareketleris_satisHareketleriId",
                        column: x => x.satisHareketleriId,
                        principalTable: "satisHareketleris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAdi = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    PersonelSoyad = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    PersonelGorsel = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: false),
                    DepartmanId = table.Column<int>(type: "int", nullable: false),
                    satisHareketleriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personels_departmans_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "departmans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personels_satisHareketleris_satisHareketleriId",
                        column: x => x.satisHareketleriId,
                        principalTable: "satisHareketleris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "uruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    UrunMarka = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Stok = table.Column<short>(type: "smallint", nullable: false),
                    AlisFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    UrunGorsel = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: false),
                    satisHareketleriId = table.Column<int>(type: "int", nullable: false),
                    KatagoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_uruns_katagoris_KatagoriId",
                        column: x => x.KatagoriId,
                        principalTable: "katagoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_uruns_satisHareketleris_satisHareketleriId",
                        column: x => x.satisHareketleriId,
                        principalTable: "satisHareketleris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_caris_satisHareketleriId",
                table: "caris",
                column: "satisHareketleriId");

            migrationBuilder.CreateIndex(
                name: "IX_faturaKalems_FaturaId",
                table: "faturaKalems",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_personels_DepartmanId",
                table: "personels",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_personels_satisHareketleriId",
                table: "personels",
                column: "satisHareketleriId");

            migrationBuilder.CreateIndex(
                name: "IX_uruns_KatagoriId",
                table: "uruns",
                column: "KatagoriId");

            migrationBuilder.CreateIndex(
                name: "IX_uruns_satisHareketleriId",
                table: "uruns",
                column: "satisHareketleriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "caris");

            migrationBuilder.DropTable(
                name: "faturaKalems");

            migrationBuilder.DropTable(
                name: "giderSiniflaris");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "uruns");

            migrationBuilder.DropTable(
                name: "faturas");

            migrationBuilder.DropTable(
                name: "departmans");

            migrationBuilder.DropTable(
                name: "katagoris");

            migrationBuilder.DropTable(
                name: "satisHareketleris");
        }
    }
}
