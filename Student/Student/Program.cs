using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student 
{
    
        public class Student
        {
            private string name;
            private string id;
            private string department;
            private float cgpa;

            public Student()
            {

            }
            public Student(string name,string id,string department,float cgpa)
            {
                this.name = name;
                this.id = id;
                this.department = department;
                this.cgpa = cgpa;

            }
            public void ShowInfo()
            {
                Console.WriteLine("Student name: " + name);
                Console.WriteLine("Student ID: " + id);
                Console.WriteLine("Student department: " + department);
                Console.WriteLine("Student cgpa: " + cgpa);
            }
        }
    
}
