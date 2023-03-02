using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entities.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Column> Columns { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<SystemLog> SystemLogs { get; set; }
        public virtual DbSet<Value> Values { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.\\SQLExpress;Database=BtyonDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Column>(entity =>
            {
                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(100);

                entity.HasOne(d => d.Value)
                .WithMany(p => p.SystemLogs)
                .HasForeignKey(d => d.ValueId)
                .HasConstraintName("FK_SystemLogs_Values");



                entity.HasOne(d => d.Column)
                    .WithMany(p => p.SystemLogs)
                    .HasForeignKey(d => d.ColumnId)
                    .HasConstraintName("FK_SystemLogs_Columns");
            });

            modelBuilder.Entity<Value>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.Value1)
                    .HasMaxLength(50)
                    .HasColumnName("Value");
                

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.Values)
                    .HasForeignKey(d => d.ColumnId)
                    .HasConstraintName("FK_Values_Columns");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
