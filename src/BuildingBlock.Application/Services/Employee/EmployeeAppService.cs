using BuildingBlock.Application.Dtos.Employee;
using BuildingBlock.Application.Interfaces.Employee;
using BuildingBlock.Domain.Aggregates.Employee.Interfaces.Services;

namespace BuildingBlock.Application.Services.Employee
{
    public class EmployeeAppService : IEmployeeAppService
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeAppService(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<List<EmployeeDto>> ListarTodosFuncionariosAssinc()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
        }


    }
}
