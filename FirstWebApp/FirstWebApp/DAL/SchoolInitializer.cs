using System;
using System.Collections.Generic;
using System.Data.Entity;

using Domain.Models;

using FirstWebApp.Context;

namespace FirstWebApp.DAL
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<CoreDbContext>
    {
        protected override void Seed(CoreDbContext context)
        {
            var students = new List<Student>
                               {
                                   new Student
                                       {
                                           FirstName = Faker.Name.First(),
                                           LastName = Faker.Name.Last(),
                                           EnrollmentDate = DateTime.Now
                                       },
                                   new Student
                                       {
                                           FirstName = Faker.Name.First(),
                                           LastName = Faker.Name.Last(),
                                           EnrollmentDate = DateTime.Now
                                       },
                                   new Student
                                       {
                                           FirstName = Faker.Name.First(),
                                           LastName = Faker.Name.Last(),
                                           EnrollmentDate = DateTime.Now
                                       }
                               };

            //TODO: Add repositiories for each entities.
//            students.ForEach(s => context.);

        }
    }
}