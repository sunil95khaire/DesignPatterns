using System.Collections.Generic;

namespace Adapter
{
    public class EmployeeAdapter : HRSystem, ITraget
    {
        public List<string> GetEmployeeList()
        {
            var employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }
    }
}
