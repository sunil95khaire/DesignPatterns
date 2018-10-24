using System;

namespace Adapter
{
    public class ThirdPartyBillingSystem
    {
        private ITraget employees;

        public ThirdPartyBillingSystem(ITraget emps)
        {
            employees = emps;
        }

        public void ShowEmployeeList()
        {
            var allEmployees = employees.GetEmployeeList();

            Console.WriteLine("Employees List");

            foreach (var e in allEmployees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
