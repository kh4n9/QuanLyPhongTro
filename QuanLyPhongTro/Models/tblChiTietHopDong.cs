namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietHopDong")]
    public partial class tblChiTietHopDong
    {
        [Key]
        public long MaCTHopDong { get; set; }

        public long? MaHopDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public int? CSD_Cu { get; set; }

        public int? CSD_Moi { get; set; }

        public int? CSN_Cu { get; set; }

        public int? CSN_Moi { get; set; }

        public int? TienVeSinh { get; set; }

        public int? TienMang { get; set; }

        public int? DaThanhToan { get; set; }

        public virtual tblHopDong tblHopDong { get; set; }
    }
}
