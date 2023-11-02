namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPhong")]
    public partial class tblPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhong()
        {
            tblHopDongs = new HashSet<tblHopDong>();
        }

        [Key]
        public int MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public int? MaLoaiPhong { get; set; }

        public byte? TrangThai { get; set; }

        public byte? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHopDong> tblHopDongs { get; set; }

        public virtual tblLoaiPhong tblLoaiPhong { get; set; }
    }
}
