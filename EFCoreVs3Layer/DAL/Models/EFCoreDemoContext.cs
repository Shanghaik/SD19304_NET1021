using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreVs3Layer.DAL.Models
{
    public partial class EFCoreDemoContext : DbContext
    {
        public EFCoreDemoContext()
        {
        }

        public EFCoreDemoContext(DbContextOptions<EFCoreDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cho> Chos { get; set; } = null!;
        public virtual DbSet<Dongvat> Dongvats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SHANGHAIK;Database=EFCoreDemo;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cho>(entity =>
            {
                entity.HasKey(e => e.MaCho)
                    .HasName("PK__Cho__3DCBB647D766796A");

                entity.ToTable("Cho");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.Property(e => e.TenCho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDvNavigation)
                    .WithMany(p => p.Chos)
                    .HasForeignKey(d => d.MaDv)
                    .HasConstraintName("FK__Cho__MaDV__398D8EEE");
            });

            modelBuilder.Entity<Dongvat>(entity =>
            {
                entity.HasKey(e => e.MaDv)
                    .HasName("PK__Dongvat__272586571469FDA3");

                entity.ToTable("Dongvat");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.Property(e => e.TenDv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TenDV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
