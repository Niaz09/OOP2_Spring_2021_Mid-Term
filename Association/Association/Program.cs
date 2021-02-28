using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "cs");
            Student s1 = new Student("Niaz", "s234", 2.45f);
            s1.Department = d1;
            s1.ShowInfo();
        }
    }
}
