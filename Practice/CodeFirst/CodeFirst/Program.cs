using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var x = new SchoolContext())
            {
                var student1 = new Student() { StudentName = "Holly", StudentID = 1};

                x.Students.Add(student1);
                x.SaveChanges();
            }
        }
    }
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Grade Grade { get; set; }
    }
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
