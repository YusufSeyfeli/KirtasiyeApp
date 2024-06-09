using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailParameters",
                columns: table => new
                {
                    EmailParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Smtp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<int>(type: "int", nullable: false),
                    SSL = table.Column<bool>(type: "bit", nullable: false),
                    Html = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailParameters", x => x.EmailParameterId);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationClaimName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.OperationClaimId);
                });

            migrationBuilder.CreateTable(
                name: "Urunlers",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimFiyat = table.Column<float>(type: "real", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunlers", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    InsanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ConfirmValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false),
                    ForgotPasswordValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForgotPasswordRequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsForgotPasswordComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.InsanId);
                });

            migrationBuilder.CreateTable(
                name: "SiparisUruns",
                columns: table => new
                {
                    SiparisUrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    SiparisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamFiyat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisUruns", x => x.SiparisUrunId);
                    table.ForeignKey(
                        name: "FK_SiparisUruns_Urunlers_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunlers",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.KullaniciId);
                    table.ForeignKey(
                        name: "FK_Kullanicis_Users_InsanId",
                        column: x => x.InsanId,
                        principalTable: "Users",
                        principalColumn: "InsanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsanId = table.Column<int>(type: "int", nullable: false),
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personels_Users_InsanId",
                        column: x => x.InsanId,
                        principalTable: "Users",
                        principalColumn: "InsanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriSiparises",
                columns: table => new
                {
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    MusteriSiparisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriSiparises", x => x.SiparisId);
                    table.ForeignKey(
                        name: "FK_MusteriSiparises_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciId");
                    table.ForeignKey(
                        name: "FK_MusteriSiparises_SiparisUruns_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "SiparisUruns",
                        principalColumn: "SiparisUrunId");
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    UserOperationClaimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.UserOperationClaimId);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciId");
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "OperationClaimId");
                });

            migrationBuilder.CreateTable(
                name: "SiparisKirtasiyes",
                columns: table => new
                {
                    SiparisKirtasiyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    SiparisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamFiyat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisKirtasiyes", x => x.SiparisKirtasiyeId);
                    table.ForeignKey(
                        name: "FK_SiparisKirtasiyes_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiparisKirtasiyeUruns",
                columns: table => new
                {
                    SiparisKirtasiyeId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    SiparisKirtasiyeUrunId = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisKirtasiyeUruns", x => x.SiparisKirtasiyeId);
                    table.ForeignKey(
                        name: "FK_SiparisKirtasiyeUruns_SiparisKirtasiyes_SiparisKirtasiyeId",
                        column: x => x.SiparisKirtasiyeId,
                        principalTable: "SiparisKirtasiyes",
                        principalColumn: "SiparisKirtasiyeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisKirtasiyeUruns_Urunlers_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunlers",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_InsanId",
                table: "Kullanicis",
                column: "InsanId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriSiparises_KullaniciId",
                table: "MusteriSiparises",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_InsanId",
                table: "Personels",
                column: "InsanId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisKirtasiyes_PersonelId",
                table: "SiparisKirtasiyes",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisKirtasiyeUruns_UrunId",
                table: "SiparisKirtasiyeUruns",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisUruns_UrunId",
                table: "SiparisUruns",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_KullaniciId",
                table: "UserOperationClaims",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailParameters");

            migrationBuilder.DropTable(
                name: "MusteriSiparises");

            migrationBuilder.DropTable(
                name: "SiparisKirtasiyeUruns");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "SiparisUruns");

            migrationBuilder.DropTable(
                name: "SiparisKirtasiyes");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Urunlers");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
