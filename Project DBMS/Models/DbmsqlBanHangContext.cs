using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project_DBMS.Models;

public partial class DbmsqlBanHangContext : DbContext
{
    public DbmsqlBanHangContext()
    {
    }

    public DbmsqlBanHangContext(DbContextOptions<DbmsqlBanHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bangdanhgium> Bangdanhgia { get; set; }

    public virtual DbSet<Chinhanh> Chinhanhs { get; set; }

    public virtual DbSet<CtDonhang> CtDonhangs { get; set; }

    public virtual DbSet<Doitac> Doitacs { get; set; }

    public virtual DbSet<Donhang> Donhangs { get; set; }

    public virtual DbSet<Hopdong> Hopdongs { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Monan> Monans { get; set; }

    public virtual DbSet<Nguoidaidien> Nguoidaidiens { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<TaikhoanNh> TaikhoanNhs { get; set; }

    public virtual DbSet<Taixe> Taixes { get; set; }

    public virtual DbSet<Tuychonmon> Tuychonmons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bangdanhgium>(entity =>
        {
            entity.HasKey(e => new { e.Mabang, e.Makh, e.Tenmon });

            entity.ToTable("BANGDANHGIA");

            entity.HasIndex(e => e.Makh, "IX_BANGDANHGIA_MAKH");

            entity.HasIndex(e => e.Tenmon, "IX_BANGDANHGIA_TENMON");

            entity.Property(e => e.Mabang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MABANG");
            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");
            entity.Property(e => e.Tenmon)
                .HasMaxLength(50)
                .HasColumnName("TENMON");
            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Likee).HasColumnName("LIKEE");
            entity.Property(e => e.Rate).HasColumnName("RATE");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Bangdanhgia)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BANGDANHGIA_KHACHHANG");

            entity.HasOne(d => d.TenmonNavigation).WithMany(p => p.Bangdanhgia)
                .HasForeignKey(d => d.Tenmon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BANGDANHGIA_MONAN");
        });

        modelBuilder.Entity<Chinhanh>(entity =>
        {
            entity.HasKey(e => e.Machinhanh);

            entity.ToTable("CHINHANH");

            entity.HasIndex(e => e.Madoitac, "IX_CHINHANH_MADOITAC");

            entity.HasIndex(e => new { e.Sotaikhoan, e.Tennganhang }, "IX_CHINHANH_SOTAIKHOAN_TENNGANHANG");

            entity.Property(e => e.Machinhanh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACHINHANH");
            entity.Property(e => e.DcChinhanh)
                .HasMaxLength(50)
                .HasColumnName("DC_CHINHANH");
            entity.Property(e => e.Giodongcua).HasColumnName("GIODONGCUA");
            entity.Property(e => e.Giomocua).HasColumnName("GIOMOCUA");
            entity.Property(e => e.Madoitac)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MADOITAC");
            entity.Property(e => e.Sotaikhoan)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SOTAIKHOAN");
            entity.Property(e => e.Tennganhang)
                .HasMaxLength(50)
                .HasColumnName("TENNGANHANG");
            entity.Property(e => e.TtChinhanh)
                .HasMaxLength(20)
                .HasColumnName("TT_CHINHANH");

            entity.HasOne(d => d.MadoitacNavigation).WithMany(p => p.Chinhanhs)
                .HasForeignKey(d => d.Madoitac)
                .HasConstraintName("FK_CHINHANH_DOITAC");

            entity.HasOne(d => d.TaikhoanNh).WithMany(p => p.Chinhanhs)
                .HasForeignKey(d => new { d.Sotaikhoan, d.Tennganhang })
                .HasConstraintName("FK_CHINHANH_TAIKHOAN_NH");

            entity.HasMany(d => d.Tenmonans).WithMany(p => p.Machinhanhs)
                .UsingEntity<Dictionary<string, object>>(
                    "Thucdon",
                    r => r.HasOne<Monan>().WithMany()
                        .HasForeignKey("Tenmonan")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_THUCDON_MONAN"),
                    l => l.HasOne<Chinhanh>().WithMany()
                        .HasForeignKey("Machinhanh")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_THUCDON_CHINHANH"),
                    j =>
                    {
                        j.HasKey("Machinhanh", "Tenmonan");
                        j.ToTable("THUCDON");
                        j.HasIndex(new[] { "Tenmonan" }, "IX_THUCDON_TENMONAN");
                        j.IndexerProperty<string>("Machinhanh")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("MACHINHANH");
                        j.IndexerProperty<string>("Tenmonan")
                            .HasMaxLength(50)
                            .HasColumnName("TENMONAN");
                    });
        });

        modelBuilder.Entity<CtDonhang>(entity =>
        {
            entity.HasKey(e => new { e.Madonhang, e.Machinhanh, e.Tenmon });

            entity.ToTable("CT_DONHANG");

            entity.HasIndex(e => e.Machinhanh, "IX_CT_DONHANG_MACHINHANH");

            entity.HasIndex(e => e.Tenmon, "IX_CT_DONHANG_TENMON");

            entity.Property(e => e.Madonhang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MADONHANG");
            entity.Property(e => e.Machinhanh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACHINHANH");
            entity.Property(e => e.Tenmon)
                .HasMaxLength(50)
                .HasColumnName("TENMON");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

            entity.HasOne(d => d.MachinhanhNavigation).WithMany(p => p.CtDonhangs)
                .HasForeignKey(d => d.Machinhanh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CT_DONHANG_CHINHANH");

            entity.HasOne(d => d.MadonhangNavigation).WithMany(p => p.CtDonhangs)
                .HasForeignKey(d => d.Madonhang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CT_DONHANG_DONHANG");

            entity.HasOne(d => d.TenmonNavigation).WithMany(p => p.CtDonhangs)
                .HasForeignKey(d => d.Tenmon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CT_DONHANG_MONAN");
        });

        modelBuilder.Entity<Doitac>(entity =>
        {
            entity.HasKey(e => e.Madoitac);

            entity.ToTable("DOITAC");

            entity.HasIndex(e => e.MaNdd, "IX_DOITAC_MA_NDD");

            entity.Property(e => e.Madoitac)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MADOITAC");
            entity.Property(e => e.DiachiKd)
                .HasMaxLength(50)
                .HasColumnName("DIACHI_KD");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Loaiamthuc)
                .HasMaxLength(20)
                .HasColumnName("LOAIAMTHUC");
            entity.Property(e => e.MaNdd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MA_NDD");
            entity.Property(e => e.Masothue)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MASOTHUE");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
            entity.Property(e => e.Tenquan)
                .HasMaxLength(50)
                .HasColumnName("TENQUAN");
            entity.Property(e => e.TpQuan)
                .HasMaxLength(50)
                .HasColumnName("TP_QUAN");

            entity.HasOne(d => d.MaNddNavigation).WithMany(p => p.Doitacs)
                .HasForeignKey(d => d.MaNdd)
                .HasConstraintName("FK_DOITAC_NGUOIDAIDIEN");
        });

        modelBuilder.Entity<Donhang>(entity =>
        {
            entity.HasKey(e => e.Madonhang);

            entity.ToTable("DONHANG");

            entity.HasIndex(e => e.Chinhanh, "IX_DONHANG_CHINHANH");

            entity.HasIndex(e => e.Khachhang, "IX_DONHANG_KHACHHANG");

            entity.HasIndex(e => e.Taixexuli, "IX_DONHANG_TAIXEXULI");

            entity.Property(e => e.Madonhang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MADONHANG");
            entity.Property(e => e.Chinhanh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CHINHANH");
            entity.Property(e => e.Hinhthucthanhtoan)
                .HasMaxLength(20)
                .HasColumnName("HINHTHUCTHANHTOAN");
            entity.Property(e => e.Khachhang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KHACHHANG");
            entity.Property(e => e.Ngaylap)
                .HasColumnType("datetime")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Phivanchuyen).HasColumnName("PHIVANCHUYEN");
            entity.Property(e => e.Taixexuli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAIXEXULI");
            entity.Property(e => e.Tinhtrang)
                .HasMaxLength(20)
                .HasColumnName("TINHTRANG");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

            entity.HasOne(d => d.ChinhanhNavigation).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.Chinhanh)
                .HasConstraintName("FK_DONHANG_CHINHANH");

            entity.HasOne(d => d.KhachhangNavigation).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.Khachhang)
                .HasConstraintName("FK_DONHANG_KHACHHANG");

            entity.HasOne(d => d.TaixexuliNavigation).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.Taixexuli)
                .HasConstraintName("FK_DONHANG_TAIXE");
        });

        modelBuilder.Entity<Hopdong>(entity =>
        {
            entity.HasKey(e => e.Mahopdong);

            entity.ToTable("HOPDONG");

            entity.HasIndex(e => e.MaNdd, "IX_HOPDONG_MA_NDD");

            entity.HasIndex(e => e.NvXuli, "IX_HOPDONG_NV_XULI");

            entity.Property(e => e.Mahopdong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAHOPDONG");
            entity.Property(e => e.MaNdd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MA_NDD");
            entity.Property(e => e.NvXuli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NV_XULI");
            entity.Property(e => e.Phikichhoat).HasColumnName("PHIKICHHOAT");
            entity.Property(e => e.PtHoahong).HasColumnName("PT_HOAHONG");
            entity.Property(e => e.TgHieuluc)
                .HasColumnType("datetime")
                .HasColumnName("TG_HIEULUC");

            entity.HasOne(d => d.MaNddNavigation).WithMany(p => p.Hopdongs)
                .HasForeignKey(d => d.MaNdd)
                .HasConstraintName("FK_HOPDONG_NGUOIDAIDIEN");

            entity.HasOne(d => d.NvXuliNavigation).WithMany(p => p.Hopdongs)
                .HasForeignKey(d => d.NvXuli)
                .HasConstraintName("FK_HOPDONG_NHANVIEN");

            entity.HasMany(d => d.Machinhanhs).WithMany(p => p.Mahopdongs)
                .UsingEntity<Dictionary<string, object>>(
                    "CtHopdong",
                    r => r.HasOne<Chinhanh>().WithMany()
                        .HasForeignKey("Machinhanh")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CT_HOPDONG_CHINHANH"),
                    l => l.HasOne<Hopdong>().WithMany()
                        .HasForeignKey("Mahopdong")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CT_HOPDONG_HOPDONG"),
                    j =>
                    {
                        j.HasKey("Mahopdong", "Machinhanh");
                        j.ToTable("CT_HOPDONG");
                        j.HasIndex(new[] { "Machinhanh" }, "IX_CT_HOPDONG_MACHINHANH");
                        j.IndexerProperty<string>("Mahopdong")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("MAHOPDONG");
                        j.IndexerProperty<string>("Machinhanh")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("MACHINHANH");
                    });
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh);

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<Monan>(entity =>
        {
            entity.HasKey(e => e.Tenmon);

            entity.ToTable("MONAN");

            entity.Property(e => e.Tenmon)
                .HasMaxLength(50)
                .HasColumnName("TENMON");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Mieuta)
                .HasMaxLength(50)
                .HasColumnName("MIEUTA");
        });

        modelBuilder.Entity<Nguoidaidien>(entity =>
        {
            entity.HasKey(e => e.MaNdd);

            entity.ToTable("NGUOIDAIDIEN");

            entity.Property(e => e.MaNdd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MA_NDD");
            entity.Property(e => e.TenNdd)
                .HasMaxLength(50)
                .HasColumnName("TEN_NDD");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv);

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.Tennv)
                .HasMaxLength(50)
                .HasColumnName("TENNV");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAIKHOAN");

            entity.HasIndex(e => e.Mataikhoan, "UQ__TAIKHOAN__2ED8B516E4EC27FF")
                .IsUnique()
                .HasFilter("([MATAIKHOAN] IS NOT NULL)");

            entity.Property(e => e.Loaitaikhoan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LOAITAIKHOAN");
            entity.Property(e => e.Mataikhoan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')")
                .HasColumnName("NGAY TAO");
            entity.Property(e => e.Taikhoan1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAIKHOAN");
        });

        modelBuilder.Entity<TaikhoanNh>(entity =>
        {
            entity.HasKey(e => new { e.Sotaikhoan, e.Tennganhang });

            entity.ToTable("TAIKHOAN_NH");

            entity.Property(e => e.Sotaikhoan)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SOTAIKHOAN");
            entity.Property(e => e.Tennganhang)
                .HasMaxLength(50)
                .HasColumnName("TENNGANHANG");
            entity.Property(e => e.ChinhanhNh)
                .HasMaxLength(50)
                .HasColumnName("CHINHANH_NH");
        });

        modelBuilder.Entity<Taixe>(entity =>
        {
            entity.HasKey(e => e.Mataixe);

            entity.ToTable("TAIXE");

            entity.HasIndex(e => new { e.Sotaikhoan, e.Tennganhang }, "IX_TAIXE_SOTAIKHOAN_TENNGANHANG");

            entity.Property(e => e.Mataixe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATAIXE");
            entity.Property(e => e.Biensoxe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BIENSOXE");
            entity.Property(e => e.Cmnd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CMND");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Khuvuchd)
                .HasMaxLength(50)
                .HasColumnName("KHUVUCHD");
            entity.Property(e => e.Phithuechan).HasColumnName("PHITHUECHAN");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
            entity.Property(e => e.Sotaikhoan)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SOTAIKHOAN");
            entity.Property(e => e.Tennganhang)
                .HasMaxLength(50)
                .HasColumnName("TENNGANHANG");

            entity.HasOne(d => d.TaikhoanNh).WithMany(p => p.Taixes)
                .HasForeignKey(d => new { d.Sotaikhoan, d.Tennganhang })
                .HasConstraintName("FK_TAIXE_TAIKHOAN_NH");
        });

        modelBuilder.Entity<Tuychonmon>(entity =>
        {
            entity.HasKey(e => new { e.Tenmon, e.Tuychon }).HasName("PK_TUYCHON");

            entity.ToTable("TUYCHONMON");

            entity.Property(e => e.Tenmon)
                .HasMaxLength(50)
                .HasColumnName("TENMON");
            entity.Property(e => e.Tuychon)
                .HasMaxLength(50)
                .HasColumnName("TUYCHON");

            entity.HasOne(d => d.TenmonNavigation).WithMany(p => p.Tuychonmons)
                .HasForeignKey(d => d.Tenmon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TUYCHONMON_MONAN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
