namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblThuePhong")]
    public partial class tblThuePhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblThuePhong()
        {
            tblDienNuocs = new HashSet<tblDienNuoc>();
        }

        [Key]
        public long MaThuePhong { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaPhong { get; set; }

        public int? GiaPhong { get; set; }

        public int? TienDatCoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThuePhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTraPhong { get; set; }

        public byte? TinhTrangThanhToan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDienNuoc> tblDienNuocs { get; set; }

        public virtual tblKhachHang tblKhachHang { get; set; }

        public virtual tblPhong tblPhong { get; set; }
    }
}
