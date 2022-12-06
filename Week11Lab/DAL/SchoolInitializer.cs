using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Week11Lab.Models;

namespace Week11Lab.DAL
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
 {
 new
Student{FirstName="Carson",MiddleName="Joe",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
 new
Student{FirstName="Meredith",MiddleName="John",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
 new
Student{FirstName="Arturo",MiddleName="Arto",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
 new
Student{FirstName="Gytis",MiddleName="Godo",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
 new
Student{FirstName="Yan",MiddleName="Mu",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
 new
Student{FirstName="Peggy",MiddleName="Sue",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
 new
Student{FirstName="Laura",MiddleName="Lynn",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
 new
Student{FirstName="Nino",MiddleName="Jack",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
 };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}
