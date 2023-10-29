namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLoaiPhong")]
    public partial class tblLoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLoaiPhong()
        {
            tblPhongs = new HashSet<tblPhong>();
        }

        [Key]
        public int MaLoaiPhong { get; set; }

        [StringLength(50)]
        public string TenLoaiPhong { get; set; }

        public int? DonGia { get; set; }

        public byte? Hidden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhong> tblPhongs { get; set; }
    }
}
