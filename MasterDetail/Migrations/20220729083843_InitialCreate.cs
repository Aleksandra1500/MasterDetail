using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterDetail.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adr__Ewid",
                columns: table => new
                {
                    adr_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adr_IdObiektu = table.Column<int>(nullable: false),
                    adr_TypAdresu = table.Column<int>(nullable: false),
                    adr_Nazwa = table.Column<string>(nullable: true),
                    adr_NazwaPelna = table.Column<string>(nullable: true),
                    adr_Telefon = table.Column<string>(nullable: true),
                    adr_Faks = table.Column<string>(nullable: true),
                    adr_Ulica = table.Column<string>(nullable: true),
                    adr_NrDomu = table.Column<string>(nullable: true),
                    adr_NrLokalu = table.Column<string>(nullable: true),
                    adr_Adres = table.Column<string>(nullable: true),
                    adr_Kod = table.Column<string>(nullable: true),
                    adr_Miejscowosc = table.Column<string>(nullable: true),
                    adr_IdWojewodztwo = table.Column<int>(nullable: true),
                    adr_IdPanstwo = table.Column<int>(nullable: true),
                    adr_NIP = table.Column<string>(nullable: true),
                    adr_Poczta = table.Column<string>(nullable: true),
                    adr_Gmina = table.Column<string>(nullable: true),
                    adr_Powiat = table.Column<string>(nullable: true),
                    adr_Skrytka = table.Column<string>(nullable: true),
                    adr_Symbol = table.Column<string>(nullable: true),
                    adr_IdGminy = table.Column<int>(nullable: true),
                    adr_IdWersja = table.Column<int>(nullable: true),
                    adr_IdZmienil = table.Column<int>(nullable: true),
                    adr_DataZmiany = table.Column<DateTime>(nullable: true),
                    adr_NrUrzeduSkarbowego = table.Column<string>(nullable: true),
                    adr_NrEORI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adr__Ewid", x => x.adr_Id);
                });

            migrationBuilder.CreateTable(
                name: "adr_Email",
                columns: table => new
                {
                    am_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    am_IdAdres = table.Column<int>(nullable: false),
                    am_Email = table.Column<string>(nullable: true),
                    am_Rodzaj = table.Column<int>(nullable: false),
                    am_Podstawowy = table.Column<bool>(nullable: false),
                    FK_adr_Email_adr__Ewid = table.Column<int>(nullable: false),
                    AdrEwidadr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adr_Email", x => x.am_Id);
                    table.ForeignKey(
                        name: "FK_adr_Email_adr__Ewid_AdrEwidadr_Id",
                        column: x => x.AdrEwidadr_Id,
                        principalTable: "adr__Ewid",
                        principalColumn: "adr_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_adr_Email_AdrEwidadr_Id",
                table: "adr_Email",
                column: "AdrEwidadr_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adr_Email");

            migrationBuilder.DropTable(
                name: "adr__Ewid");
        }
    }
}
