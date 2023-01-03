using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityegzam
{
    public class Lecture
    {
        public int Id { get; set; }
       
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Department> Departments { get; set; }

        public Lecture() { }
        public Lecture(int id,string code, string name, List<Department> departments)
        {
            Id = id;
         
            Code = code;
            Name = name;
            Departments = departments;
        }
    }
}
