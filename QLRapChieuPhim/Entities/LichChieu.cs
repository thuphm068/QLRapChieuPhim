using System.ComponentModel.DataAnnotations;


namespace QLRapChieuPhim.Entities
{
    public class LichChieu
    {
        [Key]
        [MaxLength(10)]
        public string MaPhim { get; set; } = string.Empty;
        [Required]
        [MaxLength(5)]
        public string MaRap { get; set; } = string.Empty;
        [Required]
        public DateTime NgayChieu { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(100)]
        public string ChuoiMaSuat { get; set; } = string.Empty;

    }
}
