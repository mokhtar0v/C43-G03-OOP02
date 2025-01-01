using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP_Demo.Encapsulation
{
    internal struct Employee
    {
        // encapsulation is separating data definition from its use (getters & setters)
        #region Attributes
        private int id;
        private string? name;
        private decimal salary;
        //private decimal deduction; //derived attribute
        #endregion

        #region getter & setter
        //1. getter and setters
        public int getid() => id;
        public void setid(int id)
        {
            this.id = id > 1000 && id < 10000 ? id : 9999;
        }
        #endregion

        #region property
        public string? Name
        {
            get
            {
                return name;
            }
            set //init
            {
                //data validation
                name = validatename(value);
            }

        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = validatesalary(value); }
        }
        public decimal Deduction
        {
            get { return salary * 0.2M; }
        }
        //this approach is recommended
        #endregion

        #region Constructor
        public Employee(int id, string? name, decimal salary)
        {
            this.id = id;
            this.name = validatename(name);
            this.salary = validatesalary(salary);
        }
        #endregion

        #region Methods
        public override string ToString() => $"{this.id}, {this.name}, {this.salary:c}"; 
        public string? validatename(string? name)
        {
            return name is null ? null : name.Length <= 10 ? name : name.Substring(0, 10);
        }
        public decimal validatesalary(decimal salary)
        {
            return salary >= 5000 ? salary : 5000;
        }
        #endregion

        //inside the class/struct we deal with attribute but outside it we deal with properties
    }
}
