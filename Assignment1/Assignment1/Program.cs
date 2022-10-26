using Assignment1;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        double basicSalary = 1300000;
        var employee1 = new WellsFargo("1",basicSalary,"Employee 1", "Program Associate");
        employee1.details();
        var pf = employee1.EmployeePF(basicSalary);
        string leaveDetails = employee1.LeaveDetails();
        Console.WriteLine("\nPF: "+pf+"\nLeave Details: " + leaveDetails);
        //Console.WriteLine("Hello, World!");
    }
}