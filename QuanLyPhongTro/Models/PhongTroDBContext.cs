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

        public virtual DbSet<tblCauHinh> tblCauHinhs { get; set; }
        public virtual DbSet<tblChiTietHopDong> tblChiTietHopDongs { get; set; }
        public virtual DbSet<tblHopDong> tblHopDongs { get; set; }
        public virtual DbSet<tblHopDong_KhachHang> tblHopDong_KhachHang { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<tblLoaiPhong> tblLoaiPhongs { get; set; }
        public virtual DbSet<tblPhong> tblPhongs { get; set; }
        public virtual DbSet<tblQuanLy> tblQuanLies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblHopDong>()
                .HasMany(e => e.tblHopDong_KhachHang)
                .WithRequired(e => e.tblHopDong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .HasMany(e => e.tblHopDong_KhachHang)
                .WithRequired(e => e.tblKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQuanLy>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuanLy>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);
        }
    }
}
