using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Q1.Models
{
    public partial class PRN292_Spr2020_B2Context : DbContext
    {
        public PRN292_Spr2020_B2Context()
        {
        }

        public PRN292_Spr2020_B2Context(DbContextOptions<PRN292_Spr2020_B2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DailyReport> DailyReports { get; set; }
        public virtual DbSet<InfectedCase> InfectedCases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("StudentConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DailyReport>(entity =>
            {
                entity.HasKey(e => new { e.Country, e.Date });

                entity.ToTable("DailyReport");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<InfectedCase>(entity =>
            {
                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.HistoryOfEpidemiology).HasColumnType("ntext");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(20);

                entity.Property(e => e.Province).HasMaxLength(20);

                entity.Property(e => e.TraveledFrom).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
