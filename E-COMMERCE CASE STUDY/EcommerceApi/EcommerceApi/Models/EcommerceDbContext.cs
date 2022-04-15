using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext()
        {
        }

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DboTableuser> DboTableusers { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblColor> TblColors { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblProductSizeColor> TblProductSizeColors { get; set; }
        public virtual DbSet<TblSize> TblSizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)

            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=EcommerceDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<DboTableuser>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("dbo.tableuser");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Usermail)
                    .HasMaxLength(20)
                    .HasColumnName("usermail");

                entity.Property(e => e.Username)
                    .HasMaxLength(10)
                    .HasColumnName("username")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tblCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<TblColor>(entity =>
            {
                entity.ToTable("tblColor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorName).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tblProduct");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Mrp).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblProductSizeColor>(entity =>
            {
                entity.ToTable("tblProductSizeColor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<TblSize>(entity =>
            {
                entity.ToTable("tblSize");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.SizeName).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
