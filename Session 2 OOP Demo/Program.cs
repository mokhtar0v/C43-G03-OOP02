namespace Session_2_OOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            Point p1 =new Point(3,4); // new -> just for constructor selection
            //declare for object of type Point
            Console.WriteLine($"{p1.x} {p1.y}"); //3 4
            Console.WriteLine(p1.ToString()); //before override method -> namespcae.dtname, after -> x, y
            #endregion
        }
    }
}
