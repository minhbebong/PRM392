using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Q3.Models
{
    public partial class PRN292_Summer2020_B1Context : DbContext
    {
        public PRN292_Summer2020_B1Context()
        {
        }

        public PRN292_Summer2020_B1Context(DbContextOptions<PRN292_Summer2020_B1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSchedule> CourseSchedules { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<RollCallBook> RollCallBooks { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

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

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("COURSES");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.CourseDescription).HasMaxLength(300);

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK_COURSES_INSTRUCTORS");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURSES_SUBJECTS");
            });

            modelBuilder.Entity<CourseSchedule>(entity =>
            {
                entity.HasKey(e => e.TeachingScheduleId)
                    .HasName("PK_TEACHING_SCHEDULES");

                entity.ToTable("COURSE_SCHEDULES");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.TeachingDate).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_COURSE_SCHEDULES_COURSES");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_COURSE_SCHEDULES_ROOMS");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENTS");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(300);
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("INSTRUCTORS");

                entity.Property(e => e.InstructorFirstName).HasMaxLength(50);

                entity.Property(e => e.InstructorLastName).HasMaxLength(50);

                entity.Property(e => e.InstructorMidName).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_INSTRUCTORS_DEPARTMENTS");
            });

            modelBuilder.Entity<RollCallBook>(entity =>
            {
                entity.ToTable("ROLL_CALL_BOOKS");

                entity.Property(e => e.Comment).HasMaxLength(300);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.RollCallBooks)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ROLL_CALL_BOOKS_STUDENTS");

                entity.HasOne(d => d.TeachingSchedule)
                    .WithMany(p => p.RollCallBooks)
                    .HasForeignKey(d => d.TeachingScheduleId)
                    .HasConstraintName("FK_ROLL_CALL_BOOKS_COURSE_SCHEDULES");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("ROOMS");

                entity.Property(e => e.RoomId).ValueGeneratedNever();

                entity.Property(e => e.Cap2acity).HasColumnName("CAP2acity");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RoomCode).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENTS");

                entity.Property(e => e.StudentId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MidName).HasMaxLength(50);

                entity.Property(e => e.Roll)
                    .HasMaxLength(50)
                    .HasColumnName("Roll#");
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.StudentId });

                entity.ToTable("STUDENT_COURSE");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_COURSE_COURSES");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_COURSE_STUDENTS");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("SUBJECTS");

                entity.Property(e => e.SubjectCode).HasMaxLength(50);

                entity.Property(e => e.SubjectName).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_SUBJECTS_DEPARTMENTS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
