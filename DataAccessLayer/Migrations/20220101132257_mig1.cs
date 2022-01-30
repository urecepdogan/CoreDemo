
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FiyatTeklifs",
                columns: table => new
                {
                    TeklifID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KursFiyat = table.Column<int>(type: "int", nullable: false),
                    KayıtAyi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErkenKayitIndirimMiktari = table.Column<int>(type: "int", nullable: false),
                    GorusmeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Okulu = table.Column<int>(type: "int", nullable: false),
                    BurslulukSinavDerecesi = table.Column<int>(type: "int", nullable: false),
                    SinavOkulIndirimMiktari = table.Column<int>(type: "int", nullable: false),
                    DigerIndirim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigerIndirimMiktari = table.Column<int>(type: "int", nullable: false),
                    EkstraIndirimNedeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkstraIndirimMiktari = table.Column<int>(type: "int", nullable: false),
                    ToplamIndirimMiktari = table.Column<int>(type: "int", nullable: false),
                    IndirimliKayitUcreti = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiyatTeklifs", x => x.TeklifID);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciBilgies",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Okulu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bolumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnneAdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnneMeslegi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnneTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BabaAdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BabaMeslegi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BabaTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmsKime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitAlanGorevli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciBilgies", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "Taksits",
                columns: table => new
                {
                    TaksitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaksitSayisi = table.Column<int>(type: "int", nullable: false),
                    TaksitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaksitMiktari = table.Column<int>(type: "int", nullable: false),
                    OdemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OdemeMiktari = table.Column<int>(type: "int", nullable: false),
                    ToplamOdenen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taksits", x => x.TaksitID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FiyatTeklifs");

            migrationBuilder.DropTable(
                name: "OgrenciBilgies");

            migrationBuilder.DropTable(
                name: "Taksits");
        }
    }
}
