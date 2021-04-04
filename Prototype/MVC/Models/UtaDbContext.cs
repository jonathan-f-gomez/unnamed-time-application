using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UtaPrototype.Models
{
    public partial class UtaDbContext : DbContext
    {
        public UtaDbContext()
        {
        }

        public UtaDbContext(DbContextOptions<UtaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PomoTimerSetting> PomoTimerSettings { get; set; }
        public virtual DbSet<TasksList> TasksLists { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("UtaDatabase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<PomoTimerSetting>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK__PomoTime__7C6949B1CD7C54CF");

                entity.Property(e => e.TaskId).ValueGeneratedNever();

                entity.Property(e => e.LongTimer).HasDefaultValueSql("('00:15:00')");

                entity.Property(e => e.ShortTimer).HasDefaultValueSql("('00:05:00')");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkTimer).HasDefaultValueSql("('00:25:00')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PomoTimerSettings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PomoTimer__UserI__2C3393D0");
            });

            modelBuilder.Entity<TasksList>(entity =>
            {
                entity.ToTable("TasksList");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.IsComplete).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaskInfo).HasColumnType("ntext");

                entity.Property(e => e.TaskName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
