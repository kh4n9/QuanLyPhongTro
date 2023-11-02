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
        [Key]
        [StringLength(50)]
        public string TenPhongTro { get; set; }

        [StringLength(50)]
        public string ChuPhongTro { get; set; }

        public int? DonGiaDien { get; set; }

        public int? DonGiaNuoc { get; set; }

        [StringLength(50)]
        public string DiaChiPhongTro { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }
    }
}
