using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLRapChieuPhim.Entities
{
    public class KeHoach : Entity
    {
        

        [Required]
        [MaxLength(10)]
        [ForeignKey("MaPhim")]
        public string MaPhim { get; set; } = string.Empty;
        [Required]
        [MaxLength(5)]
        [ForeignKey(nameof(CumRap))]
        public string MaCum { get; set; } = string.Empty;
        [Required]
        public DateTime NgayKhoiChieu { get; set; } = DateTime.Now;
        [Required]
        public DateTime NgayKetThuc { get; set; } = DateTime.Now;
        [MaxLength(100)]
        public string GhiChu { get; set; } = string.Empty;


    }
}
