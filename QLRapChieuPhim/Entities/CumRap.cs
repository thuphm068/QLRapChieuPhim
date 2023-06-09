﻿using System.ComponentModel.DataAnnotations;

namespace QLRapChieuPhim.Entities
{
    public class CumRap
    {
        [MaxLength(5)]
        public string MaCum { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string TenCum { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string DiaChi { get; set; } = string.Empty;

    }
}
