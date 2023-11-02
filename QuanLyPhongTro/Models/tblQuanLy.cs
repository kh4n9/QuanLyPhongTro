namespace QuanLyPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuanLy")]
    public partial class tblQuanLy
    {
        [Key]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
