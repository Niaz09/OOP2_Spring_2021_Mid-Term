using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class MainActivity
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Niaz", "18-38770-3", "CSE", 3.41f);
            s1.ShowInfo();
        }
    }
}
