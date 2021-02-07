using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class MainActivity2
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("Introduction to Programming", "110", 4);
            Course c2 = new Course("Object Oriented Programming", "234", 4);

            c1.ShowCourseInfo();
            c2.ShowCourseInfo();
        }
    }
}
