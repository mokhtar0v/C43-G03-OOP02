namespace Session2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Employee
            Employee[] emp = new Employee[3];
            emp[0] = new Employee(1, "Ali", security_privileges.Guest, 10000, new Hiring_Date(9, 1, 2004), false);
            emp[1] = new Employee(2,"Omar",security_privileges.DBA,20000,new Hiring_Date(1,1,2005), false);
            emp[2] = new Employee(3, "Sara", security_privileges.Security_Officer, 15000, new Hiring_Date(26, 3, 2002), true);
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(emp[i]);
            }
            #endregion
        }
    }
}
