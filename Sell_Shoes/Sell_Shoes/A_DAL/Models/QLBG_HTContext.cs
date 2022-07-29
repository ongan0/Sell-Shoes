using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class QLBG_HTContext : DbContext
    {
        public QLBG_HTContext()
        {
        }

        public QLBG_HTContext(DbContextOptions<QLBG_HTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CthoaDon> CthoaDons { get; set; } = null!;
        public virtual DbSet<DoanhThu> DoanhThus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=QLBG_HT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CthoaDon>(entity =>
            {
                entity.HasKey(e => new { e.MaSanpham, e.MaHoadon })
                    .HasName("PK_CTHoaDon_1");

                entity.ToTable("CTHoaDon");

                entity.Property(e => e.MaSanpham).HasColumnName("ma_sanpham");

                entity.Property(e => e.MaHoadon).HasColumnName("ma_hoadon");

                entity.Property(e => e.Dongiaban)
                    .HasColumnType("money")
                    .HasColumnName("dongiaban");

                entity.Property(e => e.MaCthoadon)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ma_cthoadon");

                entity.Property(e => e.Soluongmua).HasColumnName("soluongmua");

                entity.Property(e => e.Tongtien)
                    .HasColumnType("money")
                    .HasColumnName("tongtien");
<<<<<<< HEAD
=======

                entity.HasOne(d => d.MaSanphamNavigation)
                    .WithMany(p => p.CthoaDons)
                    .HasForeignKey(d => d.MaSanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHoaDon_HoaDon");

                entity.HasOne(d => d.MaSanpham1)
                    .WithMany(p => p.CthoaDons)
                    .HasForeignKey(d => d.MaSanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHoaDon_SanPham");
>>>>>>> Dev
            });

            modelBuilder.Entity<DoanhThu>(entity =>
            {
<<<<<<< HEAD
                entity.HasKey(e => e.Ngayxuat);
=======
                entity.HasKey(e => e.MaDoanhthu);
>>>>>>> Dev

                entity.ToTable("DoanhThu");

                entity.Property(e => e.Ngayxuat)
                    .HasColumnType("date")
                    .HasColumnName("ngayxuat");

                entity.Property(e => e.Doanhthu1)
                    .HasColumnType("money")
                    .HasColumnName("doanhthu");

                entity.Property(e => e.MaDoanhthu)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ma_doanhthu");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoadon).HasColumnName("ma_hoadon");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("ngaylap");

                entity.Property(e => e.Thanhtien)
                    .HasColumnType("money")
                    .HasColumnName("thanhtien");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanpham);

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanpham).HasColumnName("ma_sanpham");

                entity.Property(e => e.Dongianhap)
                    .HasColumnType("money")
                    .HasColumnName("dongianhap");

                entity.Property(e => e.Soluongcon).HasColumnName("soluongcon");

                entity.Property(e => e.Ten)
                    .HasMaxLength(100)
                    .HasColumnName("ten");

                entity.Property(e => e.Tenhang)
                    .HasMaxLength(100)
                    .HasColumnName("tenhang");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
