using System.ComponentModel.DataAnnotations;


namespace QLRapChieuPhim.Entities
{
    public class TheLoai
    {
        [Key]
        [MaxLength(5)]
        public string MaTheLoai { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string TenTheLoai { get; set; } = string.Empty;
    }
}
