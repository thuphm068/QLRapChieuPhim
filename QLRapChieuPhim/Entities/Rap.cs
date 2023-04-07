using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLRapChieuPhim.Entities
{
    public class Rap
    {
        [Key]
        [MaxLength(5)]
        public string MaRap { get; set; } = string.Empty;
        [Required]
        public int TongGhe { get; set; } = 0;
        [Required]
        [MaxLength(5)]
        //[ForeignKey("MaCum")]
        public string MaCum { get; set; } = string.Empty;

    }
}
