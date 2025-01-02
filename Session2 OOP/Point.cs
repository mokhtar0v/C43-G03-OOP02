using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2_OOP
{
    internal struct Point
    {
		private int x;
		private int y;

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int X
		{
			get { return x; }
			set { x = value; }
		}
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public static double Distance(Point p1, Point p2)
		{
			return Math.Sqrt((Math.Pow(p2.x - p1.x, 2) + Math.Pow(p1.y - p2.y, 2)));
		}
   //     public override string ToString()
   //     {
			//return $"The distance between the points = {Distance(Point p2, Point p2)}";
   //     }
    }
}
