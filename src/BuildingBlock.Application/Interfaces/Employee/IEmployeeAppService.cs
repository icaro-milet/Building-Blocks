namespace BuildingBlock.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<List<Dtos.Employee.EmployeeDto>> ListarTodosFuncionariosAssinc();
    }
}
