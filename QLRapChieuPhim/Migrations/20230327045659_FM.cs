using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLRapChieuPhim.Migrations
{
    /// <inheritdoc />
    public partial class FM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CumRaps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CumRaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeHoachs",
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
                    table.PrimaryKey("PK_KeHoachs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LichChieus",
                columns: table => new
                {
                    PhimId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RapId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChuoiMaSuat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieus", x => new { x.PhimId, x.RapId });
                });

            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPhim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaTheLoaiChinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    CoLa3D = table.Column<bool>(type: "bit", nullable: false),
                    CoLongTieng = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhimTheLoaiPhus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhimTheLoaiPhus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TongGhe = table.Column<int>(type: "int", nullable: false),
                    MaCum = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GioBatDau = table.Column<int>(type: "int", nullable: false),
                    PhutBatDau = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoais",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoais", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CumRaps");

            migrationBuilder.DropTable(
                name: "KeHoachs");

            migrationBuilder.DropTable(
                name: "LichChieus");

            migrationBuilder.DropTable(
                name: "Phims");

            migrationBuilder.DropTable(
                name: "PhimTheLoaiPhus");

            migrationBuilder.DropTable(
                name: "Raps");

            migrationBuilder.DropTable(
                name: "Suats");

            migrationBuilder.DropTable(
                name: "TheLoais");
        }
    }
}
