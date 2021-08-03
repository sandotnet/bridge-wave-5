using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public double salary;
        public DateTime joinDate;
        public Employee() { } //default construtor
        public Employee(int id,string name,double salary,DateTime jd) //pamterized construnctor
        {
            //assing class variables
            employeeId = id;
            employeeName = name;
            this.salary = salary;
            joinDate = jd;
        }
        public string Details()
        {
            return string.Format("Id:{0}\nName:{1}\nSalary {2}\nJoinDate {3}", employeeId, employeeName, salary, joinDate.ToShortDateString());
        }
    }
    class Test_Employee
    {
        static void Main()
        {
            Employee employee = new Employee() { employeeId = 3232, employeeName = "Roshan", salary = 23000, joinDate = new DateTime(2020, 02, 12) };
            Console.WriteLine(employee.Details());
            Employee employee1 = new Employee(3453, "Jessy", 34000, DateTime.Parse("2020,10,23"));
            Console.WriteLine(employee1.Details());
            Employee[] employees = new Employee[5];
            employees[0] = employee;
            employees[1] = employee1;
            employees[2] = new Employee(3443, "TIm", 12000, DateTime.Now);
            employees[3] = new Employee(3432, "TOm", 23000, DateTime.Now);
            employees[4] = new Employee(3493, "Ding", 20000, DateTime.Now);
            foreach(var item in employees)
            {
                Console.WriteLine(item.Details());
                Console.WriteLine("---------------------");
            }
        }
    }
    
}
