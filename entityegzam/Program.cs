// See https://aka.ms/new-console-template for more information
using entityegzam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

StudentContext context =  new StudentContext();

/*Department department = new Department();
Department department2 = new Department();
Lecture lecture = new Lecture();
Student student = new Student();
department.Name = "Astrofiziology";
department.Description = "Teaching something about nothing";
department.Lectures = new List<Lecture>();
department.Students = new List<Student>();
department2.Name = "Language";
department2.Description = "Teaching language";
department2.Lectures = new List<Lecture>();
department2.Students = new List<Student>();

var lectur1 = new Lecture { Code = "200", Name = "Mathematics", Departments = new List<Department> { department } };
var lectur2 = new Lecture { Code = "300", Name = "Biology", Departments = new List<Department> { department } };
var lectur3 = new Lecture { Code = "400", Name = "Sex education", Departments = new List<Department> { department } };
var lectur4 = new Lecture { Code = "500", Name = "Physics", Departments = new List<Department> { department } };
var lectur5 = new Lecture { Code = "600", Name = "Phylosophy", Departments = new List<Department> { department2 } };
var lectur6 = new Lecture { Code = "700", Name = "Pray", Departments = new List<Department> { department2 } };

var student1 = new Student {DepartmentId = 1, Name = "Jonas Petraitis", Age = 20, EnrolDate = DateTime.Now };
var student2 = new Student {DepartmentId= 1,  Name = "Albinas Jonaitis", Age = 22, EnrolDate = DateTime.Today };
var student3 = new Student {DepartmentId = 2, Name = "Robertas Valaitis", Age = 23, EnrolDate = DateTime.UtcNow };
var student4 = new Student {DepartmentId = 2, Name = "Viktoras Paskauskas", Age = 25, EnrolDate = DateTime.Today };
//var depart = new Department { Name = "Astrofiziology", Description = "Teaching somegint about nothing", Lectures = new List<Lecture> { lectur1, lectur2, lectur3, lectur4 }, Students = new List<Student>{ student1, student2, student3 } };
//var depart2 = new Department { Name = "Language", Description = "Teaching language", Lectures = new List<Lecture> { lectur5, lectur6 }, Students = new List<Student> { student1, student4 } };
context.Departments.AddRange(department, department2);
context.Lectures.AddRange(lectur1, lectur2, lectur3, lectur4, lectur5, lectur6);
context.Students.AddRange(student1, student2, student3, student4);
context.SaveChanges(); */

/*var depart2 = new Department { Name = "AstroPhysics", Description = "Very intresting " };
context.AddRange(depart2);
context.SaveChanges();*/


/*var pupil = new Student { DepartmentId = 1002, Name = "Česka Petraitis", Age = 45, EnrolDate = DateTime.Now };
context.Students.AddRange(pupil);
context.SaveChanges();

var pupil2 = new Student { DepartmentId = 2, Name = "Vingių Jonas", Age = 18, EnrolDate = DateTime.Today };
context.Students.AddRange(pupil2);
context.SaveChanges();*/

/*var lect = new Lecture { Code = "1", Name = "Biology"};
var lect1 = new Lecture { Code = "2", Name = "Mathematics"};
var lect2 = new Lecture { Code = "3", Name = "Physics"};
context.Lectures.AddRange(lect, lect1, lect2);
context.SaveChanges();*/

//var pupil2 = new Student { DepartmentId = 3, Name = "Albinas Antanaitis", Age = 10, EnrolDate = DateTime.Today };
/*var pupil3 = context.Students.Where(student => student.Id == 2).First();
pupil3.DepartmentId = 2;

context.SaveChanges();*/

/*foreach (var stud in context.Students)
{
    if (stud.DepartmentId == 2)
    {
        Console.WriteLine($"Name {stud.Name}, Department {stud.DepartmentId}, Age {stud.Age}");
    }
  
  

}*/

/*foreach (var dept in context.Departments)
{
    if (dept.Id == 2)
        foreach (var lect in context.Lectures) 
   
        {
            Console.WriteLine($"Name {lect.Code}, Department {lect.Name}");
        }



}*/

/*var result = context.Departments.Include(x=>x.Lectures).Where(x => x.Id == 1).FirstOrDefault();
var lectures = result.Lectures;

foreach (var item in lectures)
{
    Console.WriteLine(item.Name);
}*/

var studentDep = context.Students.Where(x => x.Id == 1).Select(x => x.DepartmentId).FirstOrDefault();
var result = context.Departments.Include(x => x.Lectures).Include(x => x.Students).Where(x => x.Id == studentDep).FirstOrDefault();
var lectures = result.Lectures;
foreach (var item in lectures)
{
    Console.WriteLine(item.Name);
}
