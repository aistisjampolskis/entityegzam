using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityegzam
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Lecture> Lectures { get; set; }

        public List <Student> Students { get; set; } 
        public Department() { }
        public Department(int id, string name, string description, List<Lecture> lectures, List<Student> students)
        {
            Id = id;
            Name = name;
            Description = description;
            Lectures = lectures;
            Students = students;
        }
    }
}
