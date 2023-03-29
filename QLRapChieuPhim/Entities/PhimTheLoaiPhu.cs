using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLRapChieuPhim.Entities
{
    public class PhimTheLoaiPhu
    {
        [Key]
        [MaxLength(10)]
        [ForeignKey("MaPhim")]
        public string MaPhim { get; set; } = string.Empty;
        [Required]
        [MaxLength(5)]
        [ForeignKey("MaTheLoai")]
        public string MaTheLoai { get; set; } = string.Empty;


    }
}
