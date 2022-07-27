using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class QLBGContext : DbContext
    {
        public QLBGContext()
        {
        }

        public QLBGContext(DbContextOptions<QLBGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DoanhThu> DoanhThus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<NhanHang> NhanHangs { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-GAKKQ82L;Database=QLBG;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoanhThu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoanhThu");

                entity.Property(e => e.NgayTongket)
                    .HasColumnType("date")
                    .HasColumnName("ngay_tongket");

                entity.Property(e => e.Thanhtien)
                    .HasColumnType("money")
                    .HasColumnName("thanhtien");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHoaDon)
                    .HasName("PK_SanPham");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHoaDon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_HoaDon")
                    .IsFixedLength();

                entity.Property(e => e.IdSanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_SanPham")
                    .IsFixedLength();

                entity.Property(e => e.Ngayxuat)
                    .HasColumnType("date")
                    .HasColumnName("ngayxuat");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("FK_HoaDon_SanPham");
            });

            modelBuilder.Entity<NhanHang>(entity =>
            {
                entity.HasKey(e => e.IdNhanHang);

                entity.ToTable("NhanHang");

                entity.Property(e => e.IdNhanHang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_NhanHang")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdSanPham)
                    .HasName("PK_HoaDon");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdSanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_SanPham")
                    .IsFixedLength();

                entity.Property(e => e.Dongia)
                    .HasColumnType("money")
                    .HasColumnName("dongia");

                entity.Property(e => e.IdNhanHang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_NhanHang")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("date")
                    .HasColumnName("ngaynhap");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.HasOne(d => d.IdNhanHangNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdNhanHang)
                    .HasConstraintName("FK_SanPham_NhanHang");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
