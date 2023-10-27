namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDienNuoc")]
    public partial class tblDienNuoc
    {
        [Key]
        public long MaDienNuoc { get; set; }

        public long? MaThuePhong { get; set; }

        public int? MaDichVu { get; set; }

        public DateTime? TuNgay { get; set; }

        public DateTime? DenNgay { get; set; }

        public int? ChiSoCu { get; set; }

        public int? ChiSoMoi { get; set; }

        public int? DonGia { get; set; }

        public byte? TinhTrangThanhToan { get; set; }

        public virtual tblDichVu tblDichVu { get; set; }

        public virtual tblThuePhong tblThuePhong { get; set; }
    }
}
