using Microsoft.EntityFrameworkCore;

namespace GetBetter.Model
{
    public class DBContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherStudent> TeachersStudents { get; set; }
        public DbSet<Homework> Hws { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<QAndA> QAs { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().ToTable("teachers");

            modelBuilder.Entity<Student>().ToTable("students");

            modelBuilder.Entity<TeacherStudent>()
                .ToTable("teachers_students")
                .HasOne(ts => ts.Student)
                .WithMany()
                .HasForeignKey(ts => ts.StudentId);

            modelBuilder.Entity<TeacherStudent>()
                .HasOne(ts => ts.Teacher)
                .WithMany()
                .HasForeignKey(ts => ts.TeacherId);

            modelBuilder.Entity<Homework>()
                .ToTable("hws")
                .HasOne(hw => hw.TeacherStudent)
                .WithMany()
                .HasForeignKey(hw => hw.TeacherStudId);

            modelBuilder.Entity<Lesson>()
                .ToTable("lessons")
                .HasOne(lesson => lesson.TeacherStudent)
                .WithMany()
                .HasForeignKey(lesson => lesson.TeacherStudId);

            modelBuilder.Entity<QAndA>().ToTable("qas");

            modelBuilder.Entity<Feedback>()
                .ToTable("feedbacks")
                .HasOne(feedback => feedback.Student)
                .WithMany()
                .HasForeignKey(feedback => feedback.StudentId);

            modelBuilder.Entity<Resource>().ToTable("resources");

            modelBuilder.Entity<News>().ToTable("news");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
