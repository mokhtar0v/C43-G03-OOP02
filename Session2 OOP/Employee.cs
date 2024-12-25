using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2_OOP
{
    public enum security_privileges
    {
        Guest, Developer, Secretary, DBA, Security_Officer
    }
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public security_privileges SecurityLevel { get; set; }
        public int Salary { get; set; }
        public Hiring_Date HiringDate { get; set; }
        public bool Gender { get; set; } //0 = male 1 = female
        public Employee(int _id, string _name, security_privileges _secuiritylvl, int _salary, Hiring_Date _HD, bool _gender)
        {
            ID = _id;
            Name = _name;
            SecurityLevel = _secuiritylvl;
            Salary = _salary;
            HiringDate = _HD;
            Gender = _gender;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HiringDate}, Gender: {(Gender == false ? "Male" : "Female")}";
        }
    }
}
