namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCauHinh")]
    public partial class tblCauHinh
    {
        [StringLength(150)]
        public string TenPhongTro { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ChuPhongTro { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string DiaChiPhongTro { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SoDienThoai { get; set; }
    }
}
