namespace Session2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Persons
            //Person persons = new Person(3);
            //persons.addperson(0, "Ahmed", 19);
            //persons.addperson(1, "Ali", 20);
            //persons.addperson(2, "Omar", 21);
            //for(int i=0; i < 3; ++i)
            //{
            //    Console.WriteLine(persons[i]);
            //}
            #endregion

            #region Point
            //Point p1 = new Point(2,4);
            //Point p2 = new Point(4,5);
            //Console.WriteLine($"The distance between point X and point Y = {Point.Distance(p1, p2)}");
            #endregion

            #region Persons 2
            Person persons2 = new Person(4);
            persons2.addperson(0, "Ali", 30);
            persons2.addperson(1, "Mohamed", 60);
            persons2.addperson(2, "Ahmed", 43);
            persons2.addperson(3, "Amar", 50);
            int max = 0;
            for(int i = 0; i < 3; i++)
            {
                if (persons2.ages[i] > persons2.ages[i+1])
                {
                    max = i;
                }
            }
            Console.WriteLine(persons2[max]);

            #endregion

            #region Employee
            //Employee[] emp = new Employee[3];
            //emp[0] = new Employee(1, "Ali", security_privileges.Guest, 10000, new Hiring_Date(9, 1, 2004), false);
            //emp[1] = new Employee(2,"Omar",security_privileges.DBA,20000,new Hiring_Date(1,1,2005), false);
            //emp[2] = new Employee(3, "Sara", security_privileges.Security_Officer, 15000, new Hiring_Date(26, 3, 2002), true);
            //for (int i = 0; i < 3; ++i)
            //{
            //    Console.WriteLine(emp[i]);
            //}
            #endregion
        }
    }
}
