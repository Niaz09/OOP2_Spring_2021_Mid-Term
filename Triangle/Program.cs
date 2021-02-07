using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        private int x;
        private int y;
        private int z;
    
    }
    public Triangle()
    {

    }
    public Triangle(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public void ShowInfo()
    {
        if (x == y)
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if (x == z)
        {

        }
    }
}
