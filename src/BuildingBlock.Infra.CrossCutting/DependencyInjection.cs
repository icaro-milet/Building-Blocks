using BuildingBlock.Application.Interfaces.Employee;
using BuildingBlock.Application.Services.Employee;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlock.Infra.CrossCutting
{
    public static class DependencyInjection
    {
        public static void AddRegisterDependencyInjections(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IEmployeeAppService, EmployeeAppService>();
        }
    }
}
