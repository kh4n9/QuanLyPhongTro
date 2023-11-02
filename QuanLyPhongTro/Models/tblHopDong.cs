namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHopDong")]
    public partial class tblHopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHopDong()
        {
            tblChiTietHopDongs = new HashSet<tblChiTietHopDong>();
            tblHopDong_KhachHang = new HashSet<tblHopDong_KhachHang>();
        }

        [Key]
        public long MaHopDong { get; set; }

        public int? MaPhong { get; set; }

        public int? GiaPhong { get; set; }

        public int? DatCoc { get; set; }

        public byte? DaKetThuc { get; set; }

        public int? DonGiaDien { get; set; }

        public int? DonGiaNuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHopDong> tblChiTietHopDongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHopDong_KhachHang> tblHopDong_KhachHang { get; set; }

        public virtual tblPhong tblPhong { get; set; }
    }
}
