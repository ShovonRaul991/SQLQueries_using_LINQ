namespace SQL_Queries1
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeTitle { get; set; }
        public int EmployeeAge { get; set; }
        public int EmployeeSalary { get; set; }

        public Employee(int id, string firstName, string lastName, string title, int age, int salary)
        {
            EmployeeId = id;
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            EmployeeTitle = title;
            EmployeeAge = age;
            EmployeeSalary = salary;
        }
    }
}