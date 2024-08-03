using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int employeeId = 0;
            string firstName = String.Empty;
            String lastName = String.Empty;
            decimal annualSalary = 0;
            char gender = '\0';
            bool isManager = false;

            Console.WriteLine("Please enter a unique Id for this employee");

            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter employee first Name");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter employee last Name");

            lastName = Console.ReadLine();

            Console.WriteLine("Please enter employee annual salary");

            annualSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter employee gender");

            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The employee is a manager (true/false)");

            isManager = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";

            string managerNarrative = (isManager) ? "part of the management team" : "currently no part of the management team";

            string narrative = $"Employee with an Id of {employeeId}";
            narrative += $"who's full name is {firstName} {lastName}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative}";

            Console.Clear();

            Console.WriteLine(narrative);





            Console.ReadKey();
        }
       
    }
}

