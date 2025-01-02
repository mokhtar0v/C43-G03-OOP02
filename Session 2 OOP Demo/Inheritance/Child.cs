using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP_Demo.Inheritance
{
    internal class Child : Parent
    {
        // child class constructors chains on oarameterless constructor of parent class
        public int Z { get; set; }

        public Child(int x, int y, int Z) : base(x, y)
        { 
            this.Z = Z;
        }
        public new int product()
        {
            return x * y * Z;
        }
        public override string ToString()
        {
            return $"X = {x}, Y = {y}, Z = {Z}";
        }
    }
}
