using System; 
using System.ComponentModel.DataAnnotations;
using System.Data.Entry;
using CodeDemo;
namespace CodeDemo
{
    public class Student
    {
        [Key]
        public int StudentId{get;set;}
        public string FirstName{get;set;}
        public string LastName {get;set;}
        public DateTime EnrollmentDate{get;set}
    }
    public class SchoolContext ; DbContext
    {
        public DbSet<Student> Students {get;set;}
    }
    class Program
    {
        static void Main(string[]args)
        {
            using (var context = new SchoolContext())
            {
                var newStudent = new Student
                {
                    FirstName = "Jane",
                    LastName =  "Dear",
                    EnrollmentDate = DateTime.Now
                };
                context.Students.Add(newStudent);
                context.SaveChanges();
                Console.WriteLine("Student Added Successfully!");
                Console.ReadKey();
            }
        }
    }
}