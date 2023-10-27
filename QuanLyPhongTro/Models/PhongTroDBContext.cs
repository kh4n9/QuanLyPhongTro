using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyPhongTro.Models
{
    public partial class PhongTroDBContext : DbContext
    {
        public PhongTroDBContext()
            : base("name=PhongTroDBContext")
        {
        }

        public virtual DbSet<tblDichVu> tblDichVus { get; set; }
        public virtual DbSet<tblDienNuoc> tblDienNuocs { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<tblLoaiPhong> tblLoaiPhongs { get; set; }
        public virtual DbSet<tblPhong> tblPhongs { get; set; }
        public virtual DbSet<tblQuanLy> tblQuanLies { get; set; }
        public virtual DbSet<tblThuePhong> tblThuePhongs { get; set; }
        public virtual DbSet<tblCauHinh> tblCauHinhs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuanLy>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuanLy>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<tblCauHinh>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);
        }
    }
}
