using System.ComponentModel.DataAnnotations;


namespace QLRapChieuPhim.Entities
{
    public class SuatChieu
    {
        [Key]
        [MaxLength(3)]
        public string MaSuat { get; set; } = string.Empty;
        [Required]
        public int GioBatDau { get; set; } = 0;
        [Required]
        public int PhutBatDau  { get; set; } = 0;



    }
}
