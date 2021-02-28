using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string dept;

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public Department() { }
        public Department(string dept, string id)
        {
            this.dept = dept;
            this.id = id;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Department: " + dept);
            Console.WriteLine("ID: " + id);
        }
      
    }
}
