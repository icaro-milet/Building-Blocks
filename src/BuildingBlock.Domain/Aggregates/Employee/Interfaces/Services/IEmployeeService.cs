namespace BuildingBlock.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<List<Entities.Employee>> GetAllEmployeesAsync();
    }
}
