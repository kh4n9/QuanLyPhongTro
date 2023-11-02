namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKhachHang")]
    public partial class tblKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhachHang()
        {
            tblHopDong_KhachHang = new HashSet<tblHopDong_KhachHang>();
        }

        [Key]
        public int MaKhachHang { get; set; }

        [StringLength(50)]
        public string TenKhach { get; set; }

        [StringLength(50)]
        public string CCCD { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        [StringLength(50)]
        public string HKTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHopDong_KhachHang> tblHopDong_KhachHang { get; set; }
    }
}
