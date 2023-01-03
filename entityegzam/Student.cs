using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityegzam
{
    public class Student
    {
        public int Id { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime EnrolDate { get; set; }
       

        public Student() { }
        public Student(int id, string name, int age, DateTime enrolDate)
        {
            Id = id;
            Name = name;
            Age = age;
            EnrolDate = enrolDate;
            
        }
    }
}
