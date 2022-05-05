using BuildingBlock.Application.Interfaces.Employee;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBlock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeAppService _employeeAppService;
        public EmployeeController(IEmployeeAppService employeeAppService)
        {
            _employeeAppService = employeeAppService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = _employeeAppService.ListarTodosFuncionariosAssinc();

            if (employees.Result.Any())
                return Ok();

            return BadRequest();
        }
    }
}
