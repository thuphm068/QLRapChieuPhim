using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLRapChieuPhim.Migrations
{
    /// <inheritdoc />
    public partial class first_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CumRap",
                columns: table => new
                {
                    MaCum = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenCum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CumRap", x => x.MaCum);
                });

            migrationBuilder.CreateTable(
                name: "SuatChieu",
                columns: table => new
                {
                    MaSuat = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    GioBatDau = table.Column<int>(type: "int", nullable: false),
                    PhutBatDau = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuatChieu", x => x.MaSuat);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    MaTheLoai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.MaTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "Rap",
                columns: table => new
                {
                    MaRap = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TongGhe = table.Column<int>(type: "int", nullable: false),
                    MaCum = table.Column<string>(type: "nvarchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rap", x => x.MaRap);
                    table.ForeignKey(
                        name: "FK_Rap_CumRap_MaCum",
                        column: x => x.MaCum,
                        principalTable: "CumRap",
                        principalColumn: "MaCum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phim",
                columns: table => new
                {
                    MaPhim = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenPhim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaTheLoaiChinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    CoLa3D = table.Column<bool>(type: "bit", nullable: false),
                    CoLongTieng = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.MaPhim);
                    table.ForeignKey(
                        name: "FK_Phim_TheLoai_MaTheLoaiChinh",
                        column: x => x.MaTheLoaiChinh,
                        principalTable: "TheLoai",
                        principalColumn: "MaTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeHoach",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPhim = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaCum = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NgayKhoiChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeHoach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeHoach_CumRap_MaCum",
                        column: x => x.MaCum,
                        principalTable: "CumRap",
                        principalColumn: "MaCum",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoach_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichChieu",
                columns: table => new
                {
                    MaPhim = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaRap = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NgayChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChuoiMaSuat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieu", x => new { x.MaPhim, x.MaRap });
                    table.ForeignKey(
                        name: "FK_LichChieu_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichChieu_Rap_MaRap",
                        column: x => x.MaRap,
                        principalTable: "Rap",
                        principalColumn: "MaRap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhimTheLoaiPhu",
                columns: table => new
                {
                    MaPhim = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhimTheLoaiPhu", x => new { x.MaTheLoai, x.MaPhim });
                    table.ForeignKey(
                        name: "FK_PhimTheLoaiPhu_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhimTheLoaiPhu_TheLoai_MaTheLoai",
                        column: x => x.MaTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "MaTheLoai"
                        //,onDelete: ReferentialAction.Cascade
                        );
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeHoach_MaCum",
                table: "KeHoach",
                column: "MaCum");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoach_MaPhim",
                table: "KeHoach",
                column: "MaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieu_MaRap",
                table: "LichChieu",
                column: "MaRap");

            migrationBuilder.CreateIndex(
                name: "IX_Phim_MaTheLoaiChinh",
                table: "Phim",
                column: "MaTheLoaiChinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhimTheLoaiPhu_MaPhim",
                table: "PhimTheLoaiPhu",
                column: "MaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_Rap_MaCum",
                table: "Rap",
                column: "MaCum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeHoach");

            migrationBuilder.DropTable(
                name: "LichChieu");

            migrationBuilder.DropTable(
                name: "PhimTheLoaiPhu");

            migrationBuilder.DropTable(
                name: "SuatChieu");

            migrationBuilder.DropTable(
                name: "Rap");

            migrationBuilder.DropTable(
                name: "Phim");

            migrationBuilder.DropTable(
                name: "CumRap");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}
