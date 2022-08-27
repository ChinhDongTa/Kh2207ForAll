﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ThongKeCCCD.Data
{
    public partial class NguoiThamGiaXacThucBcaContext : DbContext
    {
        public NguoiThamGiaXacThucBcaContext()
        {
        }

        public NguoiThamGiaXacThucBcaContext(DbContextOptions<NguoiThamGiaXacThucBcaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoQuanBhxh> CoQuanBhxh { get; set; }
        public virtual DbSet<NguoiThamGia> NguoiThamGia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.64.208.250;Initial Catalog=NguoiThamGiaXacThucBcaDb;User ID=familydb;Password=123456");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoQuanBhxh>(entity =>
            {
                entity.HasKey(e => e.MaHuyen);

                entity.ToTable("CoQuanBHXH");

                entity.Property(e => e.MaHuyen).HasMaxLength(50);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<NguoiThamGia>(entity =>
            {
                entity.Property(e => e.DaDangKyVssid)
                    .HasMaxLength(1)
                    .HasColumnName("DA_DANG_KY_VSSID");

                entity.Property(e => e.DangNhapVssid)
                    .HasMaxLength(1)
                    .HasColumnName("DANG_NHAP_VSSID");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(10)
                    .HasColumnName("gioiTinh");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(60)
                    .HasColumnName("hoTen");

                entity.Property(e => e.MaDvi)
                    .HasMaxLength(20)
                    .HasColumnName("maDvi");

                entity.Property(e => e.MaHuyen)
                    .HasMaxLength(5)
                    .HasColumnName("maHuyen");

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(12)
                    .HasColumnName("ngaySinh");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(50)
                    .HasColumnName("soBhxh");

                entity.Property(e => e.SoKcb)
                   .HasMaxLength(50)
                   .HasColumnName("soKcb");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(20)
                    .HasColumnName("soCmnd");

                entity.Property(e => e.SoDdcnCccdBca)
                    .HasMaxLength(20)
                    .HasColumnName("SO_DDCN_CCCD_BCA");

                entity.Property(e => e.ThongTinKhongChinhXac)
                    .HasMaxLength(255)
                    .HasColumnName("THONG_TIN_KHONG_CHINH_XAC");

                entity.Property(e => e.TrangThaiXacThuc)
                    .HasMaxLength(1)
                    .HasColumnName("TRANG_THAI_XAC_THUC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}