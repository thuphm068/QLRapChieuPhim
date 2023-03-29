using System.ComponentModel.DataAnnotations;


namespace QLRapChieuPhim.Entities
{
    public class NhanVien
    {
        [Key]
        [MaxLength(5)]
        public string MaNV { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string HoTen { get; set; } = string.Empty;
        [Required]
        public string MaCum { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string GioiTinh { get; set; } = string.Empty;
        [Required] 
        public DateTime NgaySinh { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(10)]
        public string SDT { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string DiaChi { get; set; } = string.Empty;


    }
}
