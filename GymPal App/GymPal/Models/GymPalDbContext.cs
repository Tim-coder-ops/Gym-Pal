using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GymPal.Models
{
    public partial class GymPalDbContext : DbContext
    {
        public GymPalDbContext()
        {
        }

        public GymPalDbContext(DbContextOptions<GymPalDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exercises> Exercises { get; set; }
        public virtual DbSet<Progress> Progress { get; set; }
        public virtual DbSet<Sets> Sets { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Workout> Workout { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=desktop-4tcpjeh;Database=GymPalDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercises>(entity =>
            {
                entity.HasKey(e => e.Exercise)
                    .HasName("PK__Exercise__051A1073244938F2");

                entity.Property(e => e.Exercise)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BodyPart)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TypeOfWorkout)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Progress>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Progress)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Progress__UserID__0D7A0286");
            });

            modelBuilder.Entity<Sets>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Exercise)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkoutId).HasColumnName("Workout ID");

                entity.HasOne(d => d.ExerciseNavigation)
                    .WithMany(p => p.Sets)
                    .HasForeignKey(d => d.Exercise)
                    .HasConstraintName("FK__Sets__Exercise__09A971A2");

                entity.HasOne(d => d.Workout)
                    .WithMany(p => p.Sets)
                    .HasForeignKey(d => d.WorkoutId)
                    .HasConstraintName("FK__Sets__Workout ID__0A9D95DB");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(120);

                entity.Property(e => e.FirstName).HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkoutNumber).HasColumnName("Workout Number");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Workout)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Workout__UserID__06CD04F7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
