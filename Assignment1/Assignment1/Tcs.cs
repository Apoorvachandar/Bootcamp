
using assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Tcs : IGovtRules
    {
        private string empid { get; set; }
        private int casualLeave { get; set; }
        private int sickLeave { get; set; }
        public int privilegeLeave { get; private set; }
        private double basicSalary { get; set; }
        private string name { get; set; }
        private string desg { get; set; }

        public Tcs(string empid, double basicSalary, string name, string desg)
        {
            this.empid = empid;
            this.basicSalary = basicSalary;
            this.name = name;
            this.desg = desg;
        }
        
           public void details()
        {
            Console.WriteLine("Emp ID: " + this.empid + "\nBasic Salary: " + this.basicSalary + "\nName: " + this.name + "\nDesignation: " + this.desg);
        }
        public double EmployeePF(double basicSalary)
        {
            return (0.12+0.0833+0.0367) * basicSalary ;
          }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuityAmount = 0;
            if (serviceCompleted > 5)
                gratuityAmount += basicSalary;

            if (serviceCompleted > 10)
                gratuityAmount += basicSalary;

            if (serviceCompleted > 20)
                gratuityAmount += basicSalary;

            return gratuityAmount;
        }

        public string LeaveDetails()
        {
            casualLeave = 12;
            sickLeave = 12;
            privilegeLeave = 10;

            return "Leave Details \nCasual Leaves: " + casualLeave.ToString() + "\nSick Leaves: " + sickLeave.ToString() + "\nPrivilege Leaves: " + privilegeLeave.ToString();
        }

    }
}
