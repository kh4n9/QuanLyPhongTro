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
            tblThuePhongs = new HashSet<tblThuePhong>();
        }

        [Key]
        public int MaKhachHang { get; set; }

        [StringLength(10)]
        public string Ho { get; set; }

        [StringLength(30)]
        public string TenLot { get; set; }

        [StringLength(10)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(150)]
        public string QueQuan { get; set; }

        [StringLength(150)]
        public string HKTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblThuePhong> tblThuePhongs { get; set; }
    }
}
