using Session_2_OOP_Demo.Class;
using Session_2_OOP_Demo.Encapsulation;
using Session_2_OOP_Demo.Inheritance;

namespace Session_2_OOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            Point p1 =new Point(3,4); // new -> just for constructor selection
            //declare for object of type Point
            //Console.WriteLine($"{p1.x} {p1.y}"); //3 4
            Console.WriteLine(p1.ToString()); //before override method -> namespcae.dtname, after -> x, y
            #endregion

            #region Encapsulation
            Employee employee = new Employee(1,"ggg",1000);
            employee.setid(20000);
            Console.WriteLine(employee.getid());
            #endregion

            #region Indexer
            Phonebook note = new Phonebook(10);
            note.addperson(0, "Ahmed", 111);
            note.addperson(1, "Ali", 222);
            note.addperson(2, "Omar", 333);
            //note.setnum("Ahmed", 9999);
            note["Ahmed"] = 66666;
            //note.getnum("Ahmed");
            Console.WriteLine(note["Ahmed"]);
            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }
            #endregion

            #region Class
            Car c1;
            //declare for reference of type car
            //c1 can refer to car or any other typer inheriting from car
            c1 = new Car(10, "Nissan Sentra");
            /// new 
            /// 1. allocate the required bytes for the allocated object in heap
            /// 2. initialize the allocated bytes for each and every attribute with its default datatype values
            /// 3. call use defined constructor (if exists)
            /// 4. return the address of the allocated object in heap to the reference.

            Console.WriteLine(c1);
            #endregion

            #region Inheritance
            Parent parent1 = new(4, 5);
            parent1.x = 5;
            parent1.y = 8;
            Console.WriteLine(parent1);
            Console.WriteLine(parent1.product());
            Child child1 = new Child(1, 2, 3);
            child1.x = 4;
            child1.y = 12;
            child1.Z = 13;
            Console.WriteLine(child1);
            Console.WriteLine(child1.product());
            #endregion
        }
    }
}
