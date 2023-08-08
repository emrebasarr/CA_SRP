namespace SRP_Employee_Validate.Model
{
    internal class EmployeeData
    {
        public static void AddEmployee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Firstname = "Emre";
            employee.Lastname = "Başarır";
            employee.Email = "asdasdsad@hotmail.com";
            Data.employees.Add(employee);
        }
    }
}