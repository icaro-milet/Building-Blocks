namespace BuildingBlock.Application.Dtos.Employee
{
    public class EmployeeDto 
    {
        public string Nome { get; set; }
        public DateOnly Aniversario { get; set; }
        public decimal Salario { get; set; }
        public EmployeeDto Cargo { get; set; }
    }
}
