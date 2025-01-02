using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP_Demo.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Constructor
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Methods
        public virtual int product()
        {
            return x * y;
        }
        public override string ToString()
        {
            return $"x = {x}, y = {y}";
        } 
        #endregion
    }
}
