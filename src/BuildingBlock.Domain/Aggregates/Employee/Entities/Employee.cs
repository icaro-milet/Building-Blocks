namespace BuildingBlock.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(
            string name, 
            DateOnly birthday, 
            decimal salary, 
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            Name = name;
            Birthday = birthday;
            Salary = salary;
            EmployeeRole = employeeRole;
        }

        public string Name { get; init; }
        public DateOnly Birthday { get; set; }
        public decimal Salary { get; set; }
        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }
    }
}
