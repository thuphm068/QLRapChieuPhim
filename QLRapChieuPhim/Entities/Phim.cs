using System.ComponentModel.DataAnnotations;

namespace QLRapChieuPhim.Entities
{
    public class Phim
    {
        [Key]
        [MaxLength(10)]
        public string MaPhim { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string TenPhim { get; set; } = string.Empty;
        [Required]
        [MaxLength(5)]
        public string MaTheLoaiChinh { get; set; } = string.Empty;
        [Required]
        public int ThoiLuong  { get; set; } = 0;
        [Required]
        public bool CoLa3D { get; set; } = false;
        [Required]
        public bool CoLongTieng { get; set; } = false;


    }
}
