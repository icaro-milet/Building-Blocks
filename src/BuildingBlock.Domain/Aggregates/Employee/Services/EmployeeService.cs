using BuildingBlock.Domain.Aggregates.Employee.Interfaces.Services;

namespace BuildingBlock.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {


        public Task<List<Entities.Employee>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
