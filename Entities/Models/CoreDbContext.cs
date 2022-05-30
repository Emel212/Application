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
        public virtual DbSet<Values> Values { get; set; }
        public virtual DbSet<SystemLogs> SystemLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MR18V5O\\SQLEXPRESS;initial catalog=DBbtyon;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Values>(entity =>
            {
                entity.HasOne(d => d.Column)
                    .WithMany(p => p.Values)
                    .HasForeignKey(d => d.ColumnId)
                    .HasConstraintName("FK_Values_Columns");
                  

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.Values)
                    .HasForeignKey(d => d.RecordId)
                    .HasConstraintName("FK_Values_Records");


            });
            modelBuilder.Entity<SystemLogs>(entity =>
                {
                    entity.HasOne(d => d.Column)
                        .WithMany(p => p.SystemLogs)
                        .HasForeignKey(d => d.ColumnId)
                        .HasConstraintName("FK_SystemLogs_Columns");

                    entity.HasOne(d => d.Record)
                     .WithMany(p => p.SystemLogs)
                     .HasForeignKey(d => d.RecordId)
                     .HasConstraintName("FK_SystemLogs_Records");



                });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
