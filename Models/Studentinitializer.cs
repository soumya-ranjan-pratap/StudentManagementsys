using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class Studentinitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            var Students = new List<Student>
            {
                new Student { Id = 1, Name = "Soumya", Date = DateTime.Now },
                new Student { Id = 2, Name = "Satya", Date = DateTime.Parse("2024-12-23") }
            };

            Students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}