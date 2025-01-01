using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP_Demo
{
    internal struct Point
    {
        public int x, y;

        //constructor: is a special function 
        //            1. named always after the struct or class name
        //            2. has no return type]
        public Point()
        {
            x = 1;
            y = 1;
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
}
