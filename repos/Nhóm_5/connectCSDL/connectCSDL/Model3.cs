using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace connectCSDL
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=StudentcontextDB")
        {
        }

        public virtual DbSet<Falculty> Falculty { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Falculty>()
                .Property(e => e.facultyName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.student_id)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.fullname)
                .IsUnicode(false);
        }
    }
}
